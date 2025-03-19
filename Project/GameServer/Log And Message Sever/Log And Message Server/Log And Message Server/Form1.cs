using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using static Log_And_Message_Server.Form1;

namespace Log_And_Message_Server
{
    public partial class Form1 : Form
    {
        private TcpListener listener;
        private List<TcpClient> clients = new List<TcpClient>();
        public Dictionary<string, List<Player>> gameRooms = new Dictionary<string, List<Player>>(); //Danh sách phòng và người chơi trong phòng
        private bool isRunning = false;
        string serverIP = "52.65.119.78";
        int port = 12345;
        private string clientname1;
        public int playerCount = 0; // int playerCount = gameRooms[roomCode].Count;
        public Dictionary<string, int> roomTurnIndices = new Dictionary<string, int>(); // Theo dõi lượt chơi của từng phòng
        private string roomCode;
        public Form1()
        {
            InitializeComponent();
            Start();
        }
        public class Player
        {
            public string Name { get; set; }
            public TcpClient Connection { get; set; }
            public int Score { get; set; }
            public string AvatarID { get; set; } // Thêm thuộc tính AvatarID
          
            public int CardRemain { get; set; } // Số quân bài còn lại

            public Player(string name, TcpClient connection)
            {
                Name = name;
                Connection = connection;
                Score = 0;
                AvatarID = string.Empty; // Khởi tạo mặc định
            }
        }

        public void Start()
        {
            if (isRunning) return;
            try
            {

                listener = new TcpListener(IPAddress.Any, port);
                listener.Start();
                isRunning = true;


                AppendToConnection($"Server started at {serverIP}:{port}\n");
                Thread acceptClientsThread = new Thread(AcceptClients);
                acceptClientsThread.IsBackground = true;
                acceptClientsThread.Start();
            }
            catch (Exception ex)
            {
                AppendToConnection($"Error starting server: {ex.Message}\n ");
            }
        }

        private string ResolveDomain(string domain)
        {
            try
            {
                IPAddress[] addresses = Dns.GetHostAddresses(domain);
                return addresses.FirstOrDefault()?.ToString();
            }
            catch (Exception ex)
            {
                AppendToConnection($"Error resolving domain: {ex.Message}\n ");
                return null;
            }
        }

        private void AcceptClients()
        {
            while (isRunning)
            {
                try
                {
                    TcpClient client = listener.AcceptTcpClient();
                    lock (clients)
                    {
                        clients.Add(client);
                    }
                    Thread handleClientThread = new Thread(() => ClientMessage(client));
                    handleClientThread.IsBackground = true;
                    handleClientThread.Start();
                }
                catch (Exception ex)
                {
                    AppendToMessage($"Error accepting client: {ex.Message}\n ");
                }
            }
        }
        private void ClientMessage(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] data = new byte[4096];

            try
            {
                // Nhận tên từ client
                int bytesRead = stream.Read(data, 0, data.Length);
                string clientName = Encoding.UTF8.GetString(data, 0, bytesRead).Trim();
                clientname1 = clientName; // Lưu tên client vào biến toàn cục

                // Hiển thị thông báo client đã kết nối
                AppendToMessage($"{clientName} đã kết nối.\n");

                while (true)
                {
                    bytesRead = stream.Read(data, 0, data.Length);
                    if (bytesRead <= 0) break;

                    string message = Encoding.UTF8.GetString(data, 0, bytesRead);
                    ProcessClientMessage(client, message);
                }
            }
            catch (Exception ex)
            {
                AppendToConnection($"Lỗi xử lý client: {ex.Message}\n");
            }
            finally
            {
                DisconnectClient(client);
            }
        }
        private void ProcessClientMessage(TcpClient client, string message)
        {
            if (message.StartsWith("JOIN_ROOM:"))
            {
                roomCode = message.Substring(10);
                if (gameRooms.ContainsKey(roomCode))
                {
                    var player = new Player(clientname1, client);
                    lock (gameRooms[roomCode])
                    {
                        gameRooms[roomCode].Add(player);
                        SendMessage(client, $"JOIN_SUCCESS:{roomCode}");
                        NotifyRoomClients(roomCode, $"{clientname1} đã tham gia phòng.");
                        BroadcastToAllClients($"{clientname1} đã tham gia phòng {roomCode}.");
                        AddPlayerToRoom(roomCode, player);
                    }
                }
                else
                {
                    SendMessage(client, "JOIN_FAILED:Phòng không tồn tại.");
                }
            }
            else if (message.StartsWith("NAME:"))
            {
                // Xử lý tên và avatar của người chơi khi kết nối
                string[] parts = message.Split('|');
                if (parts.Length == 2)
                {
                    string name = parts[0].Split(':')[1];
                    string avatarID = parts[1].Split(':')[1];

                    // Khởi tạo đối tượng Player
                    Player player = new Player(name, client);
                    player.AvatarID = avatarID; // Gán AvatarID
                    Console.WriteLine($"Player connected: {name} with AvatarID: {avatarID}");
                }
            }
            else if (message.StartsWith("PLAYCARD"))
            {
                Console.WriteLine($"Client play: {clientname1}");
                SendMessage(client, "PLAY_ACCEPT");
                NotifyRoomClients(roomCode, $"PLAYER_PLAY{clientname1} đã đánh bài.");
            }
            else if (message.StartsWith("DRAWCARD"))
            {
                NotifyRoomClients(roomCode, $"DRAW_ACCEPT{clientname1} đã đánh bài.");
            }else if (message.StartsWith("PLAYCARD"))
            {
                NotifyRoomClients(roomCode, $"PLAY_ACCEPT{clientname1} đã đánh bài.");
            }
            else if (message.StartsWith("START_GAME:"))
            {
                roomCode = message.Substring(11);
                if (gameRooms.ContainsKey(roomCode))
                {
                    // Notify all clients in the room that the game is starting
                    NotifyRoomClients(roomCode, "GAME_STARTING");

                    // Broadcast to all clients that the game has started
                    BroadcastToAllClients($"Game in room {roomCode} is starting.");
                    // Send a confirmation message back to the client who initiated the start
                    //SendMessage(client, "GAME_STARTED");
                }
                else
                {
                    SendMessage(client, "START_FAILED:Room does not exist.");
                }
            }
            if (message.StartsWith("CREATE_ROOM"))
            {
                string newRoomCode = GenerateRoomCode();
                lock (gameRooms)
                {
                    gameRooms[newRoomCode] = new List<Player>
                    {
                        new Player(clientname1, client)
                    };
                }
                SendMessage(client, $"CREATE_SUCCESS:{newRoomCode}");
                AppendToRoom($"New Room created: {newRoomCode}");

                // Broadcast the room creation to all clients
                BroadcastToAllClients($"New room {newRoomCode} was created by {clientname1}.");
            }

            else if (message.StartsWith("ROOM_MSG:"))
            {
                string[] parts = message.Substring(9).Split('|');
                if (parts.Length == 2)
                {
                    string roomCode = parts[0];
                    string chatMessage = parts[1];
                    if (gameRooms.ContainsKey(roomCode))
                    {
                        NotifyRoomClients(roomCode, $"{clientname1}: {chatMessage}");
                    }
                }
            }
        }
        private void AddPlayerToRoom(string roomCode, Player player)
        {
            AppendToRoom($"Player {player.Name} joined room {roomCode}.\n");
        }
        private void NotifyRoomClients(string roomCode, string message)
        {
            if (gameRooms.ContainsKey(roomCode))
            {
                foreach (var player in gameRooms[roomCode])
                {
                    SendMessage(player.Connection, message);
                }
            }
        }
        private void BroadcastToAllClients(string message)
        {
            lock (clients)
            {
                foreach (var client in clients)
                {
                    try
                    {
                        NetworkStream stream = client.GetStream();
                        string fullMessage = $"BROADCAST_SUCCESS:{message}";
                        byte[] data = Encoding.UTF8.GetBytes(fullMessage);
                        stream.Write(data, 0, data.Length);
                        AppendToConnection($"Broadcasted message to {client.Client.RemoteEndPoint}: {fullMessage}");
                    }
                    catch (Exception ex)
                    {
                        AppendToConnection($"Error broadcasting to client: {ex.Message}\n ");
                    }
                }
            }
        }



        private void DisconnectClient(TcpClient client)
        {
            lock (clients)
            {
                clients.Remove(client);
            }

            lock (gameRooms)
            {
                foreach (var room in gameRooms.ToList())
                {
                    var player = room.Value.FirstOrDefault(p => p.Connection == client);
                    if (player != null)
                    {
                        room.Value.Remove(player);
                        if (room.Value.Count == 0)
                        {
                            gameRooms.Remove(room.Key);
                            AppendToRoom($"Room {room.Key} removed (empty).\n ");
                        }
                    }
                }
            }

            client.Close();

            AppendToConnection($"{clientname1} disconnected.\n ");
        }

        private void SendMessage(TcpClient client, string message)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                AppendToConnection($"Error sending message: {ex.Message}\n ");
            }
        }

        private string GenerateRoomCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 5).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void AppendToConnection(string text)
        {
            if (connect_lbx.InvokeRequired)
            {
                connect_lbx.Invoke(new Action(() => connect_lbx.Items.Add(text)));
            }
            else
            {
                connect_lbx.Items.Add(text);
            }
        }

        private void AppendToMessage(string text)
        {
            if (message_lbx.InvokeRequired)
            {
                message_lbx.Invoke(new Action(() => message_lbx.Items.Add(text)));
            }
            else
            {
                message_lbx.Items.Add(text);
            }
        }

        private void AppendToRoom(string text)
        {
            if (room_lbx.InvokeRequired)
            {
                room_lbx.Invoke(new Action(() => room_lbx.Items.Add(text)));
            }
            else
            {
                room_lbx.Items.Add(text);
            }
        }
        public void BroadcastPlayerJoined(Player newPlayer)
        {
            string message = $"PLAYER_JOINED|{newPlayer.Name}|{newPlayer.AvatarID}|{newPlayer.CardRemain}";
            NotifyRoomClients(roomCode, message);
        }

        #region LOGICGAME
        public void NextTurn(string roomCode)
        {
            // Kiểm tra room tồn tại
            if (!gameRooms.ContainsKey(roomCode))
            {
                Console.WriteLine($"Room {roomCode} does not exist.");
                return;
            }

            // Lấy danh sách player trong room
            List<Player> players = gameRooms[roomCode];
            if (players.Count == 0)
            {
                Console.WriteLine($"Room {roomCode} has no players.");
                return;
            }

            // Kiểm tra và cập nhật lượt
            if (!roomTurnIndices.ContainsKey(roomCode))
            {
                // Nếu chưa có lượt cho room này, khởi tạo
                roomTurnIndices[roomCode] = 0;
            }

            int currentTurn = roomTurnIndices[roomCode];
            Console.WriteLine($"It's {players[currentTurn].Name}'s turn in room {roomCode}.");

            // Cập nhật lượt tiếp theo
            roomTurnIndices[roomCode] = (currentTurn + 1) % players.Count; // Vòng tròn lượt
        }



        #endregion
    }
}
