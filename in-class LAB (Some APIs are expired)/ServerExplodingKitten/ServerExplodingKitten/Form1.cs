using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static ServerExplodingKitten.Form1;
using static ServerExplodingKitten.Form1.Client;

namespace ServerExplodingKitten
{
    public partial class Form1 : Form
    {
        public static Form1 Instance { get; private set; }

        public Form1()
        {
            InitializeComponent();
            Instance = this;
            //InitServer();
        }

        // Bỏ vòng while(true) bên trong Task.Run
        //private void InitServer()
        //{
        //    // Vẫn chạy khởi tạo server dưới background thread
        //    Task.Run(() =>
        //    {
        //        AppendText("Initializing Server...");
        //        Server.Start(50, 26950);
        //    });

        //    // Dùng Timer trên Form1 để gọi GameLogic.Update() 
        //    // và ThreadManager.UpdateMain() trên UI thread mỗi 1/FPS giây
        //    var timer = new System.Windows.Forms.Timer();
        //    timer.Interval = 1000 / Constants.TICKS_PER_SEC;  // 1/FPS
        //    timer.Tick += (s, e) =>
        //    {
        //        GameLogic.Update();
        //        // bên trong GameLogic.Update() -> ThreadManager.UpdateMain(),
        //        // lúc này UpdateMain() đang chạy trên UI thread 
        //        // => an toàn cho Control
        //    };
        //    timer.Start();
        //}


        public void AppendText(string text)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => AppendText(text)));
                }
                else
                {
                    rtb_Server.AppendText(text + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                // Log lỗi vào RichTextBox hoặc Debug
                Console.WriteLine($"Error in AppendText: {ex.Message}");
            }
        }




        // Constants
        public static class Constants
        {
            public const int TICKS_PER_SEC = 30;
            public const int MS_PER_TICK = 1000 / TICKS_PER_SEC;
        }

        // Game Logic
        public static class GameLogic
        {
            public static void Update()
            {
                ThreadManager.UpdateMain();
            }
        }

        // Thread Manager
        public static class ThreadManager
        {
            private static readonly List<Action> executeOnMainThread = new List<Action>();
            private static readonly List<Action> executeCopiedOnMainThread = new List<Action>();
            private static bool actionToExecuteOnMainThread = false;

            /// <summary>Sets an action to be executed on the main thread.</summary>
            /// <param name="_action">The action to be executed on the main thread.</param>
            public static void ExecuteOnMainThread(Action _action)
            {
                if (_action == null)
                {
                    ThreadManager.ExecuteOnMainThread(() =>
                    {
                        Form1.Instance.AppendText("No action to execute on main thread!");
                    });
                    return;
                }

                lock (executeOnMainThread)
                {
                    executeOnMainThread.Add(_action);
                    actionToExecuteOnMainThread = true;
                }
            }

            /// <summary>Executes all code meant to run on the main thread. NOTE: Call this ONLY from the main thread.</summary>
            public static void UpdateMain()
            {
                if (actionToExecuteOnMainThread)
                {
                    executeCopiedOnMainThread.Clear();
                    lock (executeOnMainThread)
                    {
                        executeCopiedOnMainThread.AddRange(executeOnMainThread);
                        executeOnMainThread.Clear();
                        actionToExecuteOnMainThread = false;
                    }

                    for (int i = 0; i < executeCopiedOnMainThread.Count; i++)
                    {
                        executeCopiedOnMainThread[i]();
                    }
                }
            }
        }

        // Server
        public class Server
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
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    Form1.Instance.AppendText("Starting server...");
                });
                InitializeServerData();
                tcpListener = new TcpListener(IPAddress.Any, Port);
                tcpListener.Start();
                tcpListener.BeginAcceptTcpClient(TCPConnectCallback, null);

                udpListener = new UdpClient(Port);
                //udpListener.BeginReceive(UDPReceiveCallback, null);
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    Form1.Instance.AppendText($"Server started on port {Port}.");
                });

            }

            private static void TCPConnectCallback(IAsyncResult _result)
            {
                TcpClient _client = tcpListener.EndAcceptTcpClient(_result);
                tcpListener.BeginAcceptTcpClient(TCPConnectCallback, null);
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    Form1.Instance.AppendText($"Incoming connection from {_client.Client.RemoteEndPoint}...");
                });

                for (int i = 1; i <= MaxPlayers; i++)
                {
                    if (clients[i].tcp.socket == null)
                    {
                        clients[i].tcp.Connect(_client);
                        return;
                    }
                }
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    Form1.Instance.AppendText($"{_client.Client.RemoteEndPoint} failed to connect: Server full!");
                });
            }

            //private static void UDPReceiveCallback(IAsyncResult _result)
            //{
            //    try
            //    {
            //        IPEndPoint _clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
            //        byte[] _data = udpListener.EndReceive(_result, ref _clientEndPoint);
            //        udpListener.BeginReceive(UDPReceiveCallback, null);

            //        if (_data.Length < 4)
            //        {
            //            return;
            //        }

            //        using (Packet _packet = new Packet(_data))
            //        {
            //            int _clientId = _packet.ReadInt();

            //            if (_clientId == 0)
            //            {
            //                return;
            //            }

            //            if (clients[_clientId].udp.endPoint == null)
            //            {
            //                clients[_clientId].udp.Connect(_clientEndPoint);
            //                return;
            //            }

            //            if (clients[_clientId].udp.endPoint.ToString() == _clientEndPoint.ToString())
            //            {
            //                clients[_clientId].udp.HandleData(_packet);
            //            }
            //        }
            //    }
            //    catch (Exception _ex)
            //    {
            //        ThreadManager.ExecuteOnMainThread(() =>
            //        {
            //            Form1.Instance.AppendText($"Error receiving UDP data: {_ex}");
            //        });
            //    }
            //}

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
                    ThreadManager.ExecuteOnMainThread(() =>
                    {
                        Form1.Instance.AppendText($"Error sending data to {_clientEndPoint} via UDP: {_ex}");
                    });
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
                    { (int)ClientPackets.playerMovement, ServerHandle.PlayerMovement },
                    { (int)ClientPackets.drawCard, ServerHandle.DrawCard },
                    { (int)ClientPackets.playCard, ServerHandle.PlayCardReceived },
                    { (int)ClientPackets.endTurn, ServerHandle.EndTurnReceived },
                    { (int)ClientPackets.joinRoom, ServerHandle.JoinRoomReceived },
                    { (int)ClientPackets.sendBroadcast, ServerHandle.BroadcastMessageReceived },
                    { (int)ClientPackets.disconnect, ServerHandle.DisconnectReceived },
                    { (int)ClientPackets.ping, ServerHandle.EndTurnReceived },
                };
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    Form1.Instance.AppendText("Initialized packets.");
                });
            }
            public static void NextTurn()
            {
                turnQueue.Enqueue(currentTurn); // Đưa người chơi hiện tại vào cuối hàng đợi
                currentTurn = turnQueue.Dequeue(); // Lấy người chơi tiếp theo từ hàng đợi
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    Form1.Instance.AppendText($"It's now Player {currentTurn}'s turn.");
                });
                ServerSend.TurnChanged(currentTurn);
            }
        }

        // Client
        public class Client
        {
            public static int dataBufferSize = 4096;

            public int id;
            public Player player;
            public TCP tcp;
            //public UDP udp;

            public Client(int _clientId)
            {
                id = _clientId;
                tcp = new TCP(id);
                //udp = new UDP(id);
            }
            public byte[] ReceiveData(NetworkStream stream)
            {
                byte[] lengthBuffer = new byte[4];
                stream.Read(lengthBuffer, 0, 4); // Đọc chiều dài gói tin
                int packetLength = BitConverter.ToInt32(lengthBuffer, 0);

                byte[] dataBuffer = new byte[packetLength];
                stream.Read(dataBuffer, 0, packetLength); // Đọc dữ liệu gói tin
                return dataBuffer;
            }

            public class TCP
            {
                public TcpClient socket;

                private readonly int id;
                private NetworkStream stream;
                private Packet receivedData;
                private byte[] receiveBuffer;

                public TCP(int _id)
                {
                    id = _id;
                }

                public void Connect(TcpClient _socket)
                {
                    socket = _socket;
                    socket.ReceiveBufferSize = dataBufferSize;
                    socket.SendBufferSize = dataBufferSize;

                    stream = socket.GetStream();

                    // Tạo Packet buffer duy nhất để xử lý suốt vòng đời kết nối
                    receivedData = new Packet();
                    // Tạo vùng đệm tạm để BeginRead
                    receiveBuffer = new byte[dataBufferSize];

                    // Bắt đầu nhận dữ liệu từ client
                    stream.BeginRead(receiveBuffer, 0, dataBufferSize, ReceiveCallback, null);

                    // Gửi "Welcome" packet cho client (nếu có)
                    ServerSend.Welcome(id, "Welcome to the server!");
                }
                public void Disconnect()
                {
                    ThreadManager.ExecuteOnMainThread(() =>
                    {
                        Form1.Instance.AppendText($"Player {id} Disconnected from server.");
                    });

                    // Đóng socket & hủy stream
                    socket?.Close();
                    stream = null;

                    // Giải phóng packet buffer
                    receivedData = null;   // <-- Sau Disconnect, ta không dùng receivedData nữa
                    receiveBuffer = null;
                    socket = null;
                }

                public void SendData(Packet _packet)
                {
                    try
                    {
                        if (socket != null)
                        {
                            // Ghi dữ liệu xuống stream
                            stream.BeginWrite(_packet.ToArray(), 0, _packet.Length(), null, null);
                        }
                    }
                    catch (Exception _ex)
                    {
                        ThreadManager.ExecuteOnMainThread(() =>
                        {
                            Form1.Instance.AppendText($"Error sending data to player {id} via TCP: {_ex}");
                        });
                    }
                }

                //private void ReceiveCallback(IAsyncResult _result)
                //{
                //    try
                //    {
                //        int _byteLength = stream.EndRead(_result);
                //        if (_byteLength <= 0)
                //        {
                //            Disconnect();
                //            return;
                //        }

                //        byte[] _data = new byte[_byteLength];
                //        Array.Copy(receiveBuffer, _data, _byteLength);

                //        receivedData.Reset(HandleData(_data));
                //        stream.BeginRead(receiveBuffer, 0, dataBufferSize, ReceiveCallback, null);
                //    }
                //    catch (Exception _ex)
                //    {
                //        Disconnect();
                //        // TODO: disconnect
                //    }
                //}
                /// <summary>
                /// Callback được gọi khi .NET có dữ liệu mới vào stream.
                /// </summary>
                private void ReceiveCallback(IAsyncResult _result)
                {
                    try
                    {
                        // Kết thúc quá trình đọc
                        int _byteLength = stream.EndRead(_result);
                        if (_byteLength <= 0)
                        {
                            // Client đóng kết nối
                            ThreadManager.ExecuteOnMainThread(() =>
                            {
                                Form1.Instance.AppendText($"Client disconnected during ReceiveCallback.");
                            });
                            Disconnect();
                            return;
                        }

                        // Sao chép dữ liệu vừa nhận vào mảng tạm
                        byte[] _data = new byte[_byteLength];
                        Array.Copy(receiveBuffer, _data, _byteLength);

                        // [Tùy chọn] Debug in ra chuỗi UTF8
                        string receivedString = Encoding.UTF8.GetString(_data);
                        ThreadManager.ExecuteOnMainThread(() =>
                        {
                            Form1.Instance.AppendText($"Received {_byteLength} bytes from Client: {receivedString}");
                        });

                        // Ghép data vào receivedData, rồi parse
                        HandleData(_data);

                        // Tiếp tục chờ nhận dữ liệu mới
                        stream.BeginRead(receiveBuffer, 0, dataBufferSize, ReceiveCallback, null);
                    }
                    catch (Exception _ex)
                    {
                        ThreadManager.ExecuteOnMainThread(() =>
                        {
                            Form1.Instance.AppendText($"Error in ReceiveCallback: {_ex.Message}");
                        });
                        Disconnect();
                    }
                }

                /// <summary>
                /// Hàm xử lý data phân mảnh: ghép & đọc gói tin
                /// </summary>
                private bool HandleData(byte[] _data)
                {
                    // Trường hợp xấu: Disconnect() rồi --> receivedData = null
                    // => Ta có thể kiểm tra, nếu null thì return
                    if (receivedData == null)
                    {
                        // Đã disconnect, bỏ qua
                        return false;
                    }

                    // Ghép dữ liệu mới vào buffer
                    receivedData.SetBytes(_data);

                    // Cố gắng đọc hết gói tin trong buffer
                    while (receivedData.UnreadLength() >= 4)
                    {
                        // Đọc độ dài gói tin
                        int packetLength = 0;
                        try
                        {
                            // CÓ THỂ buffer = null => check ?
                            packetLength = receivedData.ReadInt();
                        }
                        catch (Exception ex)
                        {
                            ThreadManager.ExecuteOnMainThread(() =>
                            {
                                Form1.Instance.AppendText($"HandleData->ReadInt() error: {ex.Message}");
                            });
                            // Nếu xảy ra lỗi, nhiều khả năng buffer hỏng => disconnect
                            Disconnect();
                            return false;
                        }

                        if (packetLength <= 0)
                        {
                            // packetLength bất thường => bỏ
                            return false;
                        }

                        // Đủ bytes cho packet này?
                        if (receivedData.UnreadLength() >= packetLength)
                        {
                            // Đọc toàn bộ packet
                            byte[] packetBytes = receivedData.ReadBytes(packetLength);

                            // === GIẢI PACKET THỰC TẾ ===
                            using (Packet _packet = new Packet(packetBytes))
                            {
                                int packetId = _packet.ReadInt();
                                // Gọi handler
                                Server.packetHandlers[packetId](id, _packet);
                            }
                            // === HẾT PHẦN GIẢI PACKET ===
                        }
                        else
                        {
                            // Không đủ bytes => lùi readPos 4 byte "packetLength" để chờ gói tin lần sau
                            receivedData.Reset(false);
                            break;
                        }
                    }

                    return false;
                }
            }
            public void Disconnect()
            {
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    Form1.Instance.AppendText($"{tcp.socket.Client.RemoteEndPoint} has disconnected.");
                });

                player = null;
                tcp.Disconnect();
                //udp.Disconnect();
                // TODO: Tùy ý broadcast "client rời" cho những client khác
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    Form1.Instance.AppendText($"{tcp.socket.Client.RemoteEndPoint} has disconnected.");
                });
                ServerSend.PlayerDisconnected(id);
            }

            //    private bool HandleData(byte[] _data)
            //    {
            //        int _packetLength = 0;

            //        receivedData.SetBytes(_data);

            //        if (receivedData.UnreadLength() >= 4)
            //        {
            //            _packetLength = receivedData.ReadInt();
            //            if (_packetLength <= 0)
            //            {
            //                return true;
            //            }
            //        }

            //        while (_packetLength > 0 && _packetLength <= receivedData.UnreadLength())
            //        {
            //            byte[] _packetBytes = receivedData.ReadBytes(_packetLength);
            //            ThreadManager.ExecuteOnMainThread(() =>
            //            {
            //                using (Packet _packet = new Packet(_packetBytes))
            //                {
            //                    int _packetId = _packet.ReadInt();
            //                    Server.packetHandlers[_packetId](id, _packet);
            //                }
            //            });

            //            _packetLength = 0;
            //            if (receivedData.UnreadLength() >= 4)
            //            {
            //                _packetLength = receivedData.ReadInt();
            //                if (_packetLength <= 0)
            //                {
            //                    return true;
            //                }
            //            }
            //        }

            //        if (_packetLength <= 1)
            //        {
            //            return true;
            //        }

            //        return false;
            //    }
        }


        //public class UDP
        //{
        //    public IPEndPoint endPoint;
        //    private int id;

        //    public UDP(int _id)
        //    {
        //        id = _id;
        //    }

        //    public void Connect(IPEndPoint _endPoint)
        //    {
        //        endPoint = _endPoint;
        //    }
        //    public void Disconnect()
        //    {
        //        endPoint = null;
        //    }

        //    public void SendData(Packet _packet)
        //    {
        //        Server.SendUDPData(endPoint, _packet);
        //    }

        //    public void HandleData(Packet _packetData)
        //    {
        //        int _packetLength = _packetData.ReadInt();
        //        byte[] _packetBytes = _packetData.ReadBytes(_packetLength);

        //        ThreadManager.ExecuteOnMainThread(() =>
        //        {
        //            using (Packet _packet = new Packet(_packetBytes))
        //            {
        //                int _packetId = _packet.ReadInt();
        //                Server.packetHandlers[_packetId](id, _packet);
        //            }
        //        });
        //    }
        //}

        /// <summary>
        /// Hàm ngắt kết nối Client
        /// </summary>

        // Packet
        /// <summary>Sent from server to client.</summary>
        public enum ServerPackets
        {
            welcome = 1,
            roomJoined = 2,        // Th�m d�ng n�y
            playerJoinedRoom = 3,  // Th�m d�ng n�y
            roomJoinFailed = 4,    // Th�m d�ng n�y
            startGame = 5,          // Th�m d�ng n�y
            broadcastMessage = 6,
            playerDisconnected = 7,
            cardPlayed = 8,    // Gói tin thông báo lá bài được đánh
            turnChanged = 9,    // Gói tin thông báo lượt chơi thay đổi
            roomStatus = 10,    // Gói tin thông báo trạng thái phòng
            pingresponse = 11,
        }


        /// <summary>Sent from client to server.</summary>
        public enum ClientPackets
        {
            welcomeReceived = 1,
            playerMovement = 2,
            drawCard = 3,
            playCard = 4,
            endTurn = 5,
            joinRoom = 6, // Th�m d�ng n�y
            sendBroadcast = 7,
            disconnect = 8,
            ping = 9,
        }

        public class Packet : IDisposable
        {
            private List<byte> buffer;
            private byte[] readableBuffer;
            private int readPos;

            /// <summary>Creates a new empty packet (without an ID).</summary>
            public Packet()
            {
                buffer = new List<byte>(); // Intitialize buffer
                readPos = 0; // Set readPos to 0
            }

            /// <summary>Creates a new packet with a given ID. Used for sending.</summary>
            /// <param name="_id">The packet ID.</param>
            public Packet(int _id)
            {
                buffer = new List<byte>(); // Intitialize buffer
                readPos = 0; // Set readPos to 0

                Write(_id); // Write packet id to the buffer
            }

            /// <summary>Creates a packet from which data can be read. Used for receiving.</summary>
            /// <param name="_data">The bytes to add to the packet.</param>
            public Packet(byte[] _data)
            {
                buffer = new List<byte>(); // Intitialize buffer
                readPos = 0; // Set readPos to 0

                SetBytes(_data);
            }

            #region Functions
            /// <summary>Sets the packet's content and prepares it to be read.</summary>
            /// <param name="_data">The bytes to add to the packet.</param>
            public void SetBytes(byte[] _data)
            {
                Write(_data);
                readableBuffer = buffer.ToArray();
            }

            public void WriteLength()
            {
                buffer.InsertRange(0, BitConverter.GetBytes(buffer.Count)); // Thêm chiều dài gói tin vào đầu buffer
            }

            public int UnreadLength()
            {
                return buffer.Count - readPos; // Số byte chưa được đọc
            }

            /// <summary>Inserts the given int at the start of the buffer.</summary>
            /// <param name="_value">The int to insert.</param>
            public void InsertInt(int _value)
            {
                buffer.InsertRange(0, BitConverter.GetBytes(_value)); // Insert the int at the start of the buffer
            }

            /// <summary>Gets the packet's content in array form.</summary>
            public byte[] ToArray()
            {
                readableBuffer = buffer.ToArray();
                return readableBuffer;
            }

            /// <summary>Gets the length of the packet's content.</summary>
            public int Length()
            {
                return buffer.Count; // Return the length of buffer
            }


            /// <summary>Resets the packet instance to allow it to be reused.</summary>
            /// <param name="_shouldReset">Whether or not to reset the packet.</param>
            public void Reset(bool _shouldReset = true)
            {
                if (_shouldReset)
                {
                    buffer.Clear();
                    readableBuffer = null;
                    readPos = 0;
                }
                else
                {
                    readPos -= 4; // Hoặc một giá trị cụ thể nếu bạn muốn giữ lại vị trí
                }
            }
            public void ClearProcessedData()
            {
                if (readPos > 0)
                {
                    buffer.RemoveRange(0, readPos); // Xóa dữ liệu đã đọc
                    readableBuffer = buffer.ToArray(); // Làm mới buffer
                    readPos = 0; // Đặt lại vị trí đọc
                }
            }

            #endregion

            #region Write Data
            /// <summary>Adds a byte to the packet.</summary>
            /// <param name="_value">The byte to add.</param>
            public void Write(byte _value)
            {
                buffer.Add(_value);
            }
            /// <summary>Adds an array of bytes to the packet.</summary>
            /// <param name="_value">The byte array to add.</param>
            public void Write(byte[] _value)
            {
                buffer.AddRange(_value);
            }
            /// <summary>Adds a short to the packet.</summary>
            /// <param name="_value">The short to add.</param>
            public void Write(short _value)
            {
                buffer.AddRange(BitConverter.GetBytes(_value));
            }
            /// <summary>Adds an int to the packet.</summary>
            /// <param name="_value">The int to add.</param>
            public void Write(int _value)
            {
                buffer.AddRange(BitConverter.GetBytes(_value));
            }
            /// <summary>Adds a long to the packet.</summary>
            /// <param name="_value">The long to add.</param>
            public void Write(long _value)
            {
                buffer.AddRange(BitConverter.GetBytes(_value));
            }
            /// <summary>Adds a float to the packet.</summary>
            /// <param name="_value">The float to add.</param>
            public void Write(float _value)
            {
                buffer.AddRange(BitConverter.GetBytes(_value));
            }
            /// <summary>Adds a bool to the packet.</summary>
            /// <param name="_value">The bool to add.</param>
            public void Write(bool _value)
            {
                buffer.AddRange(BitConverter.GetBytes(_value));
            }
            /// <summary>Adds a string to the packet.</summary>
            /// <param name="_value">The string to add.</param>
            #endregion
            public void Write(string value)
            {
                byte[] data = Encoding.UTF8.GetBytes(value);
                Write(data.Length); // most valuable part
                buffer.AddRange(data);
            }

            #region Read Data
            /// <summary>Reads a byte from the packet.</summary>
            /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
            public byte ReadByte(bool _moveReadPos = true)
            {
                if (buffer.Count > readPos)
                {
                    // If there are unread bytes
                    byte _value = readableBuffer[readPos]; // Get the byte at readPos' position
                    if (_moveReadPos)
                    {
                        // If _moveReadPos is true
                        readPos += 1; // Increase readPos by 1
                    }
                    return _value; // Return the byte
                }
                else
                {
                    throw new Exception("Could not read value of type 'byte'!");
                }
            }

            /// <summary>Reads an array of bytes from the packet.</summary>
            /// <param name="_length">The length of the byte array.</param>
            /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
            public byte[] ReadBytes(int _length, bool _moveReadPos = true)
            {
                if (buffer.Count > readPos)
                {
                    // If there are unread bytes
                    byte[] _value = buffer.GetRange(readPos, _length).ToArray(); // Get the bytes at readPos' position with a range of _length
                    if (_moveReadPos)
                    {
                        // If _moveReadPos is true
                        readPos += _length; // Increase readPos by _length
                    }
                    return _value; // Return the bytes
                }
                else
                {
                    throw new Exception("Could not read value of type 'byte[]'!");
                }
            }

            /// <summary>Reads a short from the packet.</summary>
            /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
            public short ReadShort(bool _moveReadPos = true)
            {
                if (buffer.Count > readPos)
                {
                    // If there are unread bytes
                    short _value = BitConverter.ToInt16(readableBuffer, readPos); // Convert the bytes to a short
                    if (_moveReadPos)
                    {
                        // If _moveReadPos is true and there are unread bytes
                        readPos += 2; // Increase readPos by 2
                    }
                    return _value; // Return the short
                }
                else
                {
                    throw new Exception("Could not read value of type 'short'!");
                }
            }

            /// <summary>Reads an int from the packet.</summary>
            /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
            public int ReadInt(bool _moveReadPos = true)
            {
                if (buffer.Count >= readPos + 4) // Đảm bảo có đủ 4 byte để đọc
                {
                    int _value = BitConverter.ToInt32(readableBuffer, readPos);
                    if (_moveReadPos)
                    {
                        readPos += 4;
                    }
                    return _value;
                }
                else
                {
                    ThreadManager.ExecuteOnMainThread(() =>
                    {
                        Form1.Instance.AppendText($"Error: Cannot read int. Buffer size: {buffer.Count}, Read position: {readPos}");
                    });
                    throw new Exception("Could not read value of type 'int'!");
                }
            }


            /// <summary>Reads a long from the packet.</summary>
            /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
            public long ReadLong(bool _moveReadPos = true)
            {
                if (buffer.Count > readPos)
                {
                    // If there are unread bytes
                    long _value = BitConverter.ToInt64(readableBuffer, readPos); // Convert the bytes to a long
                    if (_moveReadPos)
                    {
                        // If _moveReadPos is true
                        readPos += 8; // Increase readPos by 8
                    }
                    return _value; // Return the long
                }
                else
                {
                    throw new Exception("Could not read value of type 'long'!");
                }
            }

            /// <summary>Reads a float from the packet.</summary>
            /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
            public float ReadFloat(bool _moveReadPos = true)
            {
                if (buffer.Count > readPos)
                {
                    // If there are unread bytes
                    float _value = BitConverter.ToSingle(readableBuffer, readPos); // Convert the bytes to a float
                    if (_moveReadPos)
                    {
                        // If _moveReadPos is true
                        readPos += 4; // Increase readPos by 4
                    }
                    return _value; // Return the float
                }
                else
                {
                    throw new Exception("Could not read value of type 'float'!");
                }
            }

            /// <summary>Reads a bool from the packet.</summary>
            /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
            public bool ReadBool(bool _moveReadPos = true)
            {
                if (buffer.Count > readPos)
                {
                    // If there are unread bytes
                    bool _value = BitConverter.ToBoolean(readableBuffer, readPos); // Convert the bytes to a bool
                    if (_moveReadPos)
                    {
                        // If _moveReadPos is true
                        readPos += 1; // Increase readPos by 1
                    }
                    return _value; // Return the bool
                }
                else
                {
                    throw new Exception("Could not read value of type 'bool'!");
                }
            }

            /// <summary>Reads a string from the packet.</summary>
            /// <param name="_moveReadPos">Whether or not to move the buffer's read position.</param>
            public string ReadString(bool _moveReadPos = true)
            {
                try
                {
                    int _length = ReadInt(); // Get the length of the string
                    string _value = Encoding.UTF8.GetString(readableBuffer, readPos, _length); // Convert the bytes to a string
                    if (_moveReadPos && _value.Length > 0)
                    {
                        // If _moveReadPos is true string is not empty
                        readPos += _length; // Increase readPos by the length of the string
                    }
                    return _value; // Return the string
                }
                catch
                {
                    throw new Exception("Could not read value of type 'string'!");
                }
            }
            #endregion
            protected virtual void Dispose(bool disposing)
            {
                if (disposing)
                {
                    // Dispose managed resources here.
                    buffer = null;
                    readableBuffer = null;
                }
                // Dispose unmanaged resources here.
            }

            public void Dispose()
            {
                Dispose(true); // Dispose of the unmanaged resources
                GC.SuppressFinalize(this);
            }
        }
        public class Player
        {
            public int id;
            public string username;

            public Player(int _id, string _username)
            {
                id = _id;
                username = _username;
            }
        }
        public class ServerHandle
        {
            public static void EndTurnReceived(int _fromClient, Packet _packet)
            {
                // Kiểm tra xem người chơi hiện tại có phải là người chơi được phép kết thúc lượt
                if (Server.currentTurn != _fromClient)
                {
                    ThreadManager.ExecuteOnMainThread(() =>
                    {
                        Form1.Instance.AppendText($"Player {_fromClient} attempted to end turn out of sequence.");
                    });
                    return;
                }

                ThreadManager.ExecuteOnMainThread(() =>
                {
                    Form1.Instance.AppendText($"Player {_fromClient} has ended their turn.");
                });

                // Gửi thông báo tới các Client rằng người chơi đã kết thúc lượt
                ServerSend.TurnChanged(Server.currentTurn);

                // Chuyển lượt sang người chơi kế tiếp
                Server.NextTurn();
            }

            public static void DrawCard(int _fromClient, Packet _packet)
            {
                //// Kiểm tra xem người chơi hiện tại có phải là người được phép rút bài
                //if (Server.currentTurn != _fromClient)
                //{
                //    ThreadManager.ExecuteOnMainThread(() =>
                //    {
                //        Form1.Instance.AppendText($"Player {_fromClient} attempted to draw a card out of turn.");
                //    });
                //    return;
                //}

                //ThreadManager.ExecuteOnMainThread(() =>
                //{
                //    Form1.Instance.AppendText($"Player {_fromClient} is drawing a card...");
                //});

                //// Lấy lá bài từ bộ bài
                //int drawnCard = GameDeck.DrawCard(); // Giả sử bạn có lớp GameDeck để quản lý bộ bài

                //ThreadManager.ExecuteOnMainThread(() =>
                //{
                //    Form1.Instance.AppendText($"Player {_fromClient} drew card ID: {drawnCard}");
                //});

                //// Gửi thông tin lá bài đã rút tới người chơi
                //ServerSend.CardDrawn(_fromClient, drawnCard);

                //// Kiểm tra hiệu ứng của lá bài (nếu cần)
                //if (GameLogic.IsExplodingKitten(drawnCard))
                //{
                //    // Nếu lá bài là Exploding Kitten, xử lý thất bại của người chơi
                //    ServerHandle.HandleExplodingKitten(_fromClient);
                //}
            }

            public static void WelcomeReceived(int _fromClient, Packet _packet)
            {
                // 1) Đọc ID và username
                int _clientIdCheck = _packet.ReadInt();
                string _username = _packet.ReadString();

                // 2) Đăng log "connected successfully" 
                // (đưa vào ThreadManager.ExecuteOnMainThread nếu cần truy cập Form)
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    Form1.Instance.AppendText(
                        $"{Server.clients[_fromClient].tcp.socket.Client.RemoteEndPoint} connected successfully and is now player {_fromClient}."
                    );
                });

                // 3) Nếu _clientIdCheck != _fromClient -> báo lỗi
                if (_fromClient != _clientIdCheck)
                {
                    ThreadManager.ExecuteOnMainThread(() =>
                    {
                        Form1.Instance.AppendText(
                           $"Player \"{_username}\" (ID: {_fromClient}) has assumed the wrong client ID ({_clientIdCheck})!"
                        );
                    });
                }
            }

            public static void DisconnectReceived(int _fromClient, Packet _packet)
            {
                int _clientId = _packet.ReadInt();
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    Form1.Instance.AppendText($"Player {_clientId} has disconnected.");
                });

                // Gửi thông báo đến các Client khác
                ServerSend.PlayerDisconnected(_clientId);

                // Xóa thông tin Client khỏi danh sách
                Server.clients[_clientId].Disconnect();
            }
            public static void PlayCardReceived(int _fromClient, Packet _packet)
            {
                if (_fromClient != Server.currentTurn)
                {
                    ThreadManager.ExecuteOnMainThread(() =>
                    {
                        Form1.Instance.AppendText($"Player {_fromClient} tried to play out of turn!");
                    });
                    return;
                }

                int cardId = _packet.ReadInt(); // Đọc ID lá bài
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    Form1.Instance.AppendText($"Player {_fromClient} played card ID: {cardId}");
                });

                // Gửi tín hiệu tới tất cả Client
                ServerSend.CardPlayed(_fromClient, cardId);
                // Broadcast message
                ServerSend.BroadcastMessage(_fromClient, $"Player {_fromClient} played card ID: {cardId}");
                // Chuyển lượt
                Server.NextTurn();
            }
            public static void BroadcastMessageReceived(int _fromClient, Packet _packet)
            {
                string message = _packet.ReadString(); // Đọc nội dung tin nhắn từ gói tin
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    Form1.Instance.AppendText($"Broadcast received from Player {_fromClient}: {message}");
                });
            }
            public static void JoinRoomReceived(int _fromClient, Packet _packet)
            {
                int roomId = _packet.ReadInt(); // Đọc ID phòng từ Client
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    Form1.Instance.AppendText($"Player {_fromClient} is attempting to join room {roomId}");
                });

                if (!Server.clientRooms.ContainsKey(_fromClient))
                {
                    Server.clientRooms[_fromClient] = roomId; // Thêm Client vào phòng
                    ThreadManager.ExecuteOnMainThread(() =>
                    {
                        Form1.Instance.AppendText($"Player {_fromClient} joined room {roomId}");
                    });
                    ServerSend.RoomStatus(_fromClient, roomId, true); // Gửi xác nhận
                }
                else
                {
                    ThreadManager.ExecuteOnMainThread(() =>
                    {
                        Form1.Instance.AppendText($"Player {_fromClient} is already in a room.");
                    });
                    ServerSend.RoomStatus(_fromClient, Server.clientRooms[_fromClient], false); // Gửi lỗi
                }
                foreach (var client in Server.clientRooms)
                {
                    if (client.Value == roomId && client.Key != _fromClient) // Các Client cùng phòng
                    {
                        ServerSend.BroadcastMessage(client.Key, $"Player {_fromClient} has joined room {roomId}");
                    }
                }
            }
            public static void PlayerMovement(int _fromClient, Packet _packet)
            {
                // Check if there are any players in the game
                if (Server.clientRooms.Count == 0)
                {
                    ThreadManager.ExecuteOnMainThread(() =>
                    {
                        Form1.Instance.AppendText("No players in the game to switch turns.");
                    });
                    return;
                }

                // Get the current player ID
                int currentPlayerId = Server.currentTurn;

                // Find the next player in the turn order
                int nextPlayerId = -1;
                foreach (var client in Server.clientRooms)
                {
                    if (client.Key != currentPlayerId)
                    {
                        nextPlayerId = client.Key;
                        break;
                    }
                }

                // If no next player is found, reset to the first player
                if (nextPlayerId == -1)
                {
                    nextPlayerId = Server.clientRooms.Keys.First();
                }

                // Update the current turn to the next player
                Server.currentTurn = nextPlayerId;

                // Notify all clients about the turn change
                ServerSend.TurnChanged(nextPlayerId);

                // Log the turn change
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    Form1.Instance.AppendText($"Turn changed to player {nextPlayerId}");
                });
            }
        }
        public class ServerSend
        {
            private Socket socket;
            private NetworkStream stream;

            public void SendData(string message)
            {
                try
                {
                    if (socket.Connected)
                    {
                        byte[] data = Encoding.UTF8.GetBytes(message);
                        stream.Write(data, 0, data.Length);
                    }
                }
                catch (Exception ex)
                {
                    ThreadManager.ExecuteOnMainThread(() =>
                    {
                        Form1.Instance.AppendText($"Error sending data: {ex.Message}");
                    });
                }
            }

            private static void SendTCPData(int _toClient, Packet _packet)
            {
                _packet.WriteLength();
                Server.clients[_toClient].tcp.SendData(_packet); // Send data to the specified client 
            }

            //private static void SendUDPData(int _toClient, Packet _packet)
            //{
            //    _packet.WriteLength();
            //    Server.clients[_toClient].udp.SendData(_packet);
            //}

            private static void SendTCPDataToAll(Packet _packet)
            {
                _packet.WriteLength();
                for (int i = 1; i <= Server.MaxPlayers; i++)
                {
                    Server.clients[i].tcp.SendData(_packet);
                }
            }

            //private static void SendUDPDataToAll(Packet _packet)
            //{
            //    _packet.WriteLength();
            //    for (int i = 1; i <= Server.MaxPlayers; i++)
            //    {
            //        Server.clients[i].udp.SendData(_packet);
            //    }
            //}

            public static void PlayerDisconnected(int _id)
            {
                using (Packet _packet = new Packet((int)ServerPackets.playerDisconnected))
                {
                    _packet.Write(_id); // Send ID of the disconnected client
                    SendTCPDataToAll(_packet); // Broadcast to all clients
                }
            }

            #region Packets
            public static void Welcome(int _toClient, string _msg)
            {
                using (Packet _packet = new Packet((int)ServerPackets.welcome))
                {
                    _packet.Write(_msg);
                    _packet.Write(_toClient);

                    SendTCPData(_toClient, _packet);
                }
            }
            #endregion

            public static void CardPlayed(int _fromClient, int _cardId)
            {
                using (Packet _packet = new Packet((int)ServerPackets.cardPlayed))
                {
                    _packet.Write(_fromClient); // ID of the player who played the card
                    _packet.Write(_cardId);     // ID of the card
                    ThreadManager.ExecuteOnMainThread(() =>
                    {
                        Form1.Instance.AppendText($"Server is sending cardPlayed: Player {_fromClient}, Card {_cardId}");
                    });
                    SendTCPDataToAll(_packet);
                }
            }

            public static void TurnChanged(int _nextPlayerId)
            {
                using (Packet _packet = new Packet((int)ServerPackets.turnChanged))
                {
                    _packet.Write(_nextPlayerId); // ID of the next player

                    SendTCPDataToAll(_packet);
                }
            }

            public static void RoomStatus(int _toClient, int roomId, bool success)
            {
                using (Packet _packet = new Packet((int)ServerPackets.roomStatus))
                {
                    _packet.Write(success); // Status (true/false)
                    _packet.Write(roomId);  // Room ID

                    SendTCPData(_toClient, _packet);
                }
            }

            public static void BroadcastMessage(int _toClient, string message)
            {
                using (Packet _packet = new Packet((int)ServerPackets.broadcastMessage))
                {
                    _packet.Write(message); // Message content
                    SendTCPData(_toClient, _packet);
                    ThreadManager.ExecuteOnMainThread(() =>
                    {
                        ThreadManager.ExecuteOnMainThread(() =>
                        {
                            Form1.Instance.AppendText("Message broadcasted successfully.");
                        });
                    });
                }
            }
            public static void CardDrawn(int _toClient, int cardId)
            {
                using (Packet _packet = new Packet((int)ServerPackets.cardPlayed))
                {
                    _packet.Write(cardId); // Gửi ID của lá bài
                    SendTCPData(_toClient, _packet); // Gửi tới Client
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Lúc này Form đã được tạo handle xong
            // => sẵn sàng cho Invoke, AppendText, v.v.
            Task.Run(() =>
            {
                AppendText("Initializing Server...");
                Server.Start(50, 26950);
            });

            // Hoặc cũng có thể đặt Timer ở đây
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000 / Constants.TICKS_PER_SEC;
            timer.Tick += (s2, e2) =>
            {
                GameLogic.Update();
            };
            timer.Start();
        }
    }
}
