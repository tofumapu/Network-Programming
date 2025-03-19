using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;

public class ServerClient
{
    public int Id { get; set; }
    public string Name { get; set; }

    private static Dictionary<int, ServerClient> clients = new Dictionary<int, ServerClient>();
    private static Dictionary<int, DateTime> lastPingTimes = new Dictionary<int, DateTime>();
    private TcpClient tcpClient;
    private NetworkStream stream;
    public ServerClient(int id, TcpClient client)
    {
        Id = id;
        tcpClient = client;
        stream = tcpClient.GetStream(); // Lấy NetworkStream từ TcpClient

        Console.WriteLine($"Client {Id} connected.");
    }

    public bool IsConnected
    {
        get
        {
            return tcpClient != null && tcpClient.Connected;
        }
    }
    public byte[] ReceiveData()
    {
        try
        {
            if (tcpClient != null && tcpClient.Connected && stream.DataAvailable)
            {
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                byte[] data = new byte[bytesRead];
                Array.Copy(buffer, data, bytesRead);
                Console.WriteLine($"Received {bytesRead} bytes from Client {Id}");
                return data;
            }
            else
            {
                // Không ghi log liên tục nếu không có dữ liệu
                return new byte[0];
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error receiving data from Client {Id}: {ex.Message}");
            return new byte[0];
        }
    }

    private void Broadcast(Packet packet)
    {
        foreach (var client in clients.Values)
        {
            client.SendPacket(packet);
        }
    }

    public void SendPacket(Packet packet)
    {
        try
        {
            if (tcpClient != null && tcpClient.Connected && stream != null)
            {
                byte[] data = packet.ToArray(); // Chuyển đổi Packet thành byte[]
                stream.Write(data, 0, data.Length); // Gửi dữ liệu qua NetworkStream
                Console.WriteLine($"Packet sent to Client {Id}: {packet.Length} bytes");
            }
            else
            {
                Console.WriteLine($"Failed to send packet: Client {Id} is not connected or stream is null.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error sending packet to Client {Id}: {ex.Message}");
        }
    }
}
