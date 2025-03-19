using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using ServerWithWinForm;


namespace GameServer
{
    class ServerSend
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
                FormServer.Instance.rtb_Server.AppendText($"Error sending data: {ex.Message}");
            }
        }

        private static void SendTCPData(int _toClient, Packet _packet)
        {
            _packet.WriteLength();
            Server.clients[_toClient].tcp.SendData(_packet); // Send data to the specified client 
        }

        private static void SendUDPData(int _toClient, Packet _packet)
        {
            _packet.WriteLength();
            Server.clients[_toClient].udp.SendData(_packet);
        }

        private static void SendTCPDataToAll(Packet _packet)
        {
            _packet.WriteLength();
            for (int i = 1; i <= Server.MaxPlayers; i++)
            {
                Server.clients[i].tcp.SendData(_packet);
            }
        }

        private static void SendUDPDataToAll(Packet _packet)
        {
            _packet.WriteLength();
            for (int i = 1; i <= Server.MaxPlayers; i++)
            {
                Server.clients[i].udp.SendData(_packet);
            }
        }

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
                FormServer.Instance.rtb_Server.AppendText($"Server is sending cardPlayed: Player {_fromClient}, Card {_cardId}");
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
                FormServer.Instance.rtb_Server.AppendText($"Sending broadcast message to Client {_toClient}: {message}");
            }
        }
    }
}
