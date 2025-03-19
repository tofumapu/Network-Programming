using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using ServerWithWinForm;

namespace GameServer
{
    class Client
    {
        public static int dataBufferSize = 4096;

        public int id;
        public Player player;
        public TCP tcp;
        public UDP udp;

        public Client(int _clientId)
        {
            id = _clientId;
            tcp = new TCP(id);
            udp = new UDP(id);
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

                receivedData = new Packet();
                receiveBuffer = new byte[dataBufferSize];

                stream.BeginRead(receiveBuffer, 0, dataBufferSize, ReceiveCallback, null);

                ServerSend.Welcome(id, "Welcome to the server!");
            }
            public void Disconnect()
            {
                FormServer.Instance.rtb_Server.AppendText($"Player {id} Disconnected from server.");
                socket.Close();
                stream = null;
                receivedData = null;
                receiveBuffer = null;
            }

            public void SendData(Packet _packet)
            {
                try
                {
                    if (socket != null)
                    {
                        stream.BeginWrite(_packet.ToArray(), 0, _packet.Length(), null, null);
                    }
                }
                catch (Exception _ex)
                {
                    FormServer.Instance.rtb_Server.AppendText($"Error sending data to player {id} via TCP: {_ex}");
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
            private void ReceiveCallback(IAsyncResult _result)
            {
                try
                {
                    int _byteLength = stream.EndRead(_result);
                    if (_byteLength <= 0)
                    {
                        FormServer.Instance.rtb_Server.AppendText($"Client disconnected during ReceiveCallback.");
                        Disconnect(); // Disconnect if no data is received
                        return;
                    }

                    byte[] _data = new byte[_byteLength];
                    Array.Copy(receiveBuffer, _data, _byteLength);

                    // Decode the received bytes to a UTF-8 string
                    string receivedString = Encoding.UTF8.GetString(_data);
                    FormServer.Instance.rtb_Server.AppendText($"Received {_byteLength} bytes from Client: {receivedString}"); // Log the received string

                    receivedData.Reset(HandleData(_data)); // Process the received data

                    stream.BeginRead(receiveBuffer, 0, dataBufferSize, ReceiveCallback, null); // Continue reading data
                }
                catch (Exception _ex)
                {
                    FormServer.Instance.rtb_Server.AppendText($"Error in ReceiveCallback: {_ex.Message}"); // Log detailed error
                    Disconnect(); // Disconnect if an error occurs
                }
            }
            private bool HandleData(byte[] _data)
            {
                receivedData.SetBytes(_data); // Đưa dữ liệu mới vào buffer

                // Kiểm tra có đủ 4 byte để đọc chiều dài gói tin
                while (receivedData.UnreadLength() >= 4) // Lặp để xử lý nhiều gói tin trong buffer
                {
                    int packetLength = receivedData.ReadInt(); // Đọc chiều dài gói tin

                    if (packetLength <= 0)
                    {
                        receivedData.Reset(); // Reset nếu không có gói tin hợp lệ
                        return true;
                    }

                    // Kiểm tra đủ dữ liệu để đọc toàn bộ gói tin
                    if (receivedData.UnreadLength() >= packetLength)
                    {
                        byte[] packetBytes = receivedData.ReadBytes(packetLength);
                        using (Packet _packet = new Packet(packetBytes))
                        {
                            int packetId = _packet.ReadInt(); // Đọc ID gói tin
                            Server.packetHandlers[packetId](id, _packet); // Gọi handler tương ứng
                        }

                        receivedData.ClearProcessedData(); // Xóa dữ liệu đã xử lý
                        return true;
                    }
                    else
                    {
                        // Không đủ dữ liệu để xử lý toàn bộ gói tin
                        receivedData.Reset(); // Reset buffer để chờ thêm dữ liệu
                        return false;
                    }
                }

                return false; // Không đủ dữ liệu
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


        public class UDP
        {
            public IPEndPoint endPoint;

            private int id;

            public UDP(int _id)
            {
                id = _id;
            }

            public void Connect(IPEndPoint _endPoint)
            {
                endPoint = _endPoint;
            }
            public void Disconnect() {
                endPoint = null;

            }

            public void SendData(Packet _packet)
            {
                Server.SendUDPData(endPoint, _packet);
            }

            public void HandleData(Packet _packetData)
            {
                int _packetLength = _packetData.ReadInt();
                byte[] _packetBytes = _packetData.ReadBytes(_packetLength);

                ThreadManager.ExecuteOnMainThread(() =>
                {
                    using (Packet _packet = new Packet(_packetBytes))
                    {
                        int _packetId = _packet.ReadInt();
                        Server.packetHandlers[_packetId](id, _packet);
                    }
                });
            }
        }
        public void Disconnect()
        {
            FormServer.Instance.rtb_Server.AppendText($"{tcp.socket.Client.RemoteEndPoint} has disconnected.");

            player = null;
            tcp.Disconnect();
            udp.Disconnect();
            // TODO: tell all other players that this player has disconnected
            FormServer.Instance.rtb_Server.AppendText($"{tcp.socket.Client.RemoteEndPoint} has disconnected.");
            ServerSend.PlayerDisconnected(id);
        }
    }
}