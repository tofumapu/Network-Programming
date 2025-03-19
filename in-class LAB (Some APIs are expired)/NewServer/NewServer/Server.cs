using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Server
{
    private TcpListener server;
    private Dictionary<int, ServerClient> clients = new Dictionary<int, ServerClient>();
    private int nextClientId = 1;
    private NetworkStream stream;
    private byte[] buffer = new byte[1024];
    private Dictionary<int, DateTime> lastPingTimes = new Dictionary<int, DateTime>();

    public void Start(IPAddress ipAddress, int port)
    {
        server = new TcpListener(ipAddress, port);
        server.Start();
        Console.WriteLine($"Server started on {ipAddress}:{port}");
        StartListening();
    }

    private void StartListening()
    {
        server.BeginAcceptTcpClient(AcceptClient, null);
    }

    private void AcceptClient(IAsyncResult result)
    {
        TcpClient client = server.EndAcceptTcpClient(result);
        ServerClient newClient = new ServerClient(nextClientId, client);
        clients[nextClientId] = newClient;
        nextClientId++;

        Console.WriteLine($"Client {newClient.Id} connected.");
        StartListening();
    }

    public void ProcessClientData()
    {
        List<int> clientsToRemove = new List<int>();

        foreach (var client in clients.Values)
        {
            if (client.IsConnected)
            {
                byte[] data = client.ReceiveData();

                if (data.Length > 0)
                {
                    HandleData(client, new Packet(data)); // Xử lý gói tin nếu có dữ liệu
                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine($"Client {client.Id} disconnected.");
                clientsToRemove.Add(client.Id);
            }
        }

        foreach (int clientId in clientsToRemove)
        {
            clients.Remove(clientId);
        }
    }

    public void CheckPingTimeouts()
    {
        DateTime now = DateTime.UtcNow;
        List<int> clientsToRemove = new List<int>();

        foreach (var client in clients.Values)
        {
            if (!client.IsConnected || !lastPingTimes.ContainsKey(client.Id) || (now - lastPingTimes[client.Id]).TotalSeconds > 10)
            {
                Console.WriteLine($"Client {client.Id} timed out or disconnected.");
                clientsToRemove.Add(client.Id);

                // Gửi thông báo ngắt kết nối tới các client khác
                Packet disconnectPacket = new Packet();
                disconnectPacket.Write((int)ServerPackets.playerDisconnected);
                disconnectPacket.Write(client.Id);
                Broadcast(disconnectPacket); 
            }
        }

        foreach (int clientId in clientsToRemove)
        {
            clients.Remove(clientId);
        }
    }

    private void HandleData(ServerClient client, Packet packet)
    {
        int packetId = packet.ReadInt();

        switch (packetId)
        {
            case (int)ClientPackets.ping:
                HandlePing(client);
                break;
            case (int)ClientPackets.disconnect:
                HandleDisconnect(client);
                break;
            case (int)ClientPackets.playCard:
                HandlePlayCard(client, packet);
                break;
            case (int)ClientPackets.endTurn:
                HandleEndTurn(client);
                break;
            case (int)ClientPackets.joinRoom:
                HandleJoinRoom(client, packet);
                break;
            case (int)ClientPackets.sendBroadcast:
                HandleBroadcast(client, packet);
                break;
            default:
                Console.WriteLine($"Unknown packet ID: {packetId}");
                break;
        }
    }

    private void HandleJoinRoom(ServerClient client, Packet packet)
    {
        Console.WriteLine($"Client {client.Id} requests to join room.");
        Packet roomStatusPacket = new Packet();
        roomStatusPacket.Write((int)ServerPackets.roomStatus);
        roomStatusPacket.Write(clients.Count);

        foreach (var c in clients.Values)
        {
            roomStatusPacket.Write(c.Id);
            roomStatusPacket.Write(c.Name ?? "Player");
        }
        client.SendPacket(roomStatusPacket);
    }

    private void Broadcast(Packet packet)
    {
        byte[] data = packet.ToArray(); // Chuyển đổi Packet thành byte[]

        foreach (var client in clients.Values)
        {
            client.SendPacket(new Packet(data)); // Gửi mảng byte[] tới từng client
        }
    }


    private void HandleBroadcast(ServerClient client, Packet packet)
    {
        string message = packet.ReadString();
        Console.WriteLine($"Broadcast message from Client {client.Id}: {message}");
        BroadcastMessage(Encoding.UTF8.GetBytes(message));
    }

    private void BroadcastMessage(byte[] data)
    {
        foreach (var client in clients.Values)
        {
            client.SendPacket(new Packet(data));
        }
    }

    private void HandleDrawCard(ServerClient client)
    {
        Console.WriteLine($"Client {client.Id} requested to draw a card.");
        // Thêm logic xử lý bốc bài
    }

    private void HandlePlayCard(ServerClient client, Packet packet)
    {
        int cardId = packet.ReadInt();
        Console.WriteLine($"Client {client.Id} played card ID: {cardId}");
        // Thêm logic xử lý chơi bài
    }

    private void HandleEndTurn(ServerClient client)
    {
        Console.WriteLine($"Client {client.Id} ended their turn.");
        // Thêm logic xử lý kết thúc lượt
    }

    private void HandleDisconnect(ServerClient client)
    {
        Console.WriteLine($"Client {client.Id} disconnected.");

        // Thông báo cho tất cả các client khác về việc ngắt kết nối
        Packet disconnectPacket = new Packet();
        disconnectPacket.Write((int)ServerPackets.playerDisconnected);
        disconnectPacket.Write(client.Id);
        Broadcast(disconnectPacket); // Pass Packet instead of byte[]

        // Xóa client khỏi danh sách
        clients.Remove(client.Id);
    }

    public byte[] ReceiveData()
    {
        if (stream.DataAvailable)
        {
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            byte[] data = new byte[bytesRead];
            Array.Copy(buffer, data, bytesRead);
            return data;
        }
        return Array.Empty<byte>(); // Return an empty array instead of null
    }

    public Packet ReceivePacket(ServerClient client)
    {
        try
        {
            if (stream.DataAvailable)
            {
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                return new Packet(buffer.Take(bytesRead).ToArray());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error receiving packet from Client {client.Id}: {ex.Message}");
        }
        return new Packet(); // Return a default Packet instead of null
    }

    public void SetStream(NetworkStream networkStream)
    {
        stream = networkStream;
    }

    private void HandlePing(ServerClient client)
    {
        // Cập nhật thời gian Ping cuối cùng của client
        lastPingTimes[client.Id] = DateTime.UtcNow;
    }


    private void HandleJoinRoom(ServerClient client, byte[] data)
    {
        Packet packet = new Packet(data);
        int clientId = packet.ReadInt();
        Console.WriteLine($"Client {clientId} requests to join room.");

        // Sửa: Sử dụng Packet đúng cách
        Packet responsePacket = new Packet();
        responsePacket.Write((int)ServerPackets.roomJoined);
        client.SendPacket(responsePacket);
    }
}
