using ServerWithWinForm;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GameServer
{
    class ServerHandle
    {
        public static void WelcomeReceived(int _fromClient, Packet _packet)
        {
            int _clientIdCheck = _packet.ReadInt();
            string _username = _packet.ReadString();

            FormServer.Instance.rtb_Server.AppendText($"{Server.clients[_fromClient].tcp.socket.Client.RemoteEndPoint} connected successfully and is now player {_fromClient}.");
            if (_fromClient != _clientIdCheck)
            {
                FormServer.Instance.rtb_Server.AppendText($"Player \"{_username}\" (ID: {_fromClient}) has assumed the wrong client ID ({_clientIdCheck})!");
            }
        }
        public static void DisconnectReceived(int _fromClient, Packet _packet)
        {
            int _clientId = _packet.ReadInt();
            FormServer.Instance.rtb_Server.AppendText($"Player {_clientId} has disconnected.");

            // Gửi thông báo đến các Client khác
            ServerSend.PlayerDisconnected(_clientId);

            // Xóa thông tin Client khỏi danh sách
            Server.clients[_clientId].Disconnect();
        }
        public static void PlayCardReceived(int _fromClient, Packet _packet)
        {
            if (_fromClient != Server.currentTurn)
            {
                FormServer.Instance.rtb_Server.AppendText($"Player {_fromClient} tried to play out of turn!");
                return;
            }

            int cardId = _packet.ReadInt(); // Đọc ID lá bài
            FormServer.Instance.rtb_Server.AppendText($"Player {_fromClient} played card ID: {cardId}");

            // Gửi tín hiệu tới tất cả Client
            ServerSend.CardPlayed(_fromClient, cardId);

            // Chuyển lượt
            Server.NextTurn();
        }
        public static void BroadcastMessageReceived(int _fromClient, Packet _packet)
        {
            string message = _packet.ReadString(); // Đọc nội dung tin nhắn từ gói tin
            FormServer.Instance.rtb_Server.AppendText($"Broadcast received from Player {_fromClient}: {message}");
        }
        public static void JoinRoomReceived(int _fromClient, Packet _packet)
        {
            int roomId = _packet.ReadInt(); // Đọc ID phòng từ Client
            FormServer.Instance.rtb_Server.AppendText($"Player {_fromClient} is attempting to join room {roomId}");

            if (!Server.clientRooms.ContainsKey(_fromClient))
            {
                Server.clientRooms[_fromClient] = roomId; // Thêm Client vào phòng
                FormServer.Instance.rtb_Server.AppendText($"Player {_fromClient} joined room {roomId}");
                ServerSend.RoomStatus(_fromClient, roomId, true); // Gửi xác nhận
            }
            else
            {
                FormServer.Instance.rtb_Server.AppendText($"Player {_fromClient} is already in a room.");
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
    }
}