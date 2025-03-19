using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using ServerWithWinForm;

namespace GameServer
{
    class Server
    {
        public static int MaxPlayers { get; private set; }
        public static Dictionary<int, int> clientRooms = new Dictionary<int, int>();
        public static int Port { get; private set; }
        public static Dictionary<int, Client> clients = new Dictionary<int, Client>();
        public delegate void PacketHandler(int _fromClient, Packet _packet);
        public static Dictionary<int, PacketHandler> packetHandlers;
        public static int currentTurn = 1; // ID của Client đang được phép đánh bài
        private static Queue<int> turnQueue = new Queue<int>(); // Danh sách thứ tự lượt
        private static TcpListener tcpListener;
        private static UdpClient udpListener;

        public static void Start(int _maxPlayers, int _port)
        {
            MaxPlayers = _maxPlayers;
            Port = _port;

            FormServer.Instance.rtb_Server.AppendText("Starting server...");
            InitializeServerData();

            tcpListener = new TcpListener(IPAddress.Any, Port);
            tcpListener.Start();
            tcpListener.BeginAcceptTcpClient(TCPConnectCallback, null);

            udpListener = new UdpClient(Port);
            udpListener.BeginReceive(UDPReceiveCallback, null);

            FormServer.Instance.rtb_Server.AppendText($"Server started on port {Port}.");
        }

        private static void TCPConnectCallback(IAsyncResult _result)
        {
            TcpClient _client = tcpListener.EndAcceptTcpClient(_result);
            tcpListener.BeginAcceptTcpClient(TCPConnectCallback, null);
            FormServer.Instance.rtb_Server.AppendText($"Incoming connection from {_client.Client.RemoteEndPoint}...");

            for (int i = 1; i <= MaxPlayers; i++)
            {
                if (clients[i].tcp.socket == null)
                {
                    clients[i].tcp.Connect(_client);
                    return;
                }
            }

            FormServer.Instance.rtb_Server.AppendText($"{_client.Client.RemoteEndPoint} failed to connect: Server full!");
        }

        private static void UDPReceiveCallback(IAsyncResult _result)
        {
            try
            {
                IPEndPoint _clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] _data = udpListener.EndReceive(_result, ref _clientEndPoint);
                udpListener.BeginReceive(UDPReceiveCallback, null);

                if (_data.Length < 4)
                {
                    return;
                }

                using (Packet _packet = new Packet(_data))
                {
                    int _clientId = _packet.ReadInt();

                    if (_clientId == 0)
                    {
                        return;
                    }

                    if (clients[_clientId].udp.endPoint == null)
                    {
                        clients[_clientId].udp.Connect(_clientEndPoint);
                        return;
                    }

                    if (clients[_clientId].udp.endPoint.ToString() == _clientEndPoint.ToString())
                    {
                        clients[_clientId].udp.HandleData(_packet);
                    }
                }
            }
            catch (Exception _ex)
            {
                FormServer.Instance.rtb_Server.AppendText($"Error receiving UDP data: {_ex}");
            }
        }

        public static void SendUDPData(IPEndPoint _clientEndPoint, Packet _packet)
        {
            try
            {
                if (_clientEndPoint != null)
                {
                    udpListener.BeginSend(_packet.ToArray(), _packet.Length(), _clientEndPoint, null, null);
                }
            }
            catch (Exception _ex)
            {
                FormServer.Instance.rtb_Server.AppendText($"Error sending data to {_clientEndPoint} via UDP: {_ex}");
            }
        }

        private static void InitializeServerData()
        {
            for (int i = 1; i <= MaxPlayers; i++)
            {
                clients.Add(i, new Client(i));
                turnQueue.Enqueue(i); // Thêm tất cả Client vào hàng đợi lượt
            }

            packetHandlers = new Dictionary<int, PacketHandler>()
            {
                { (int)ClientPackets.welcomeReceived, ServerHandle.WelcomeReceived },
                { (int)ClientPackets.disconnect, ServerHandle.DisconnectReceived },
                { (int)ClientPackets.playCard, ServerHandle.PlayCardReceived },
                { (int)ServerPackets.broadcastMessage, ServerHandle.BroadcastMessageReceived },
            };
            FormServer.Instance.rtb_Server.AppendText("Initialized packets.");
        }
        public static void NextTurn()
        {
            turnQueue.Enqueue(currentTurn); // Đưa người chơi hiện tại vào cuối hàng đợi
            currentTurn = turnQueue.Dequeue(); // Lấy người chơi tiếp theo từ hàng đợi

            FormServer.Instance.rtb_Server.AppendText($"It's now Player {currentTurn}'s turn.");
            ServerSend.TurnChanged(currentTurn);
        }

    }
}