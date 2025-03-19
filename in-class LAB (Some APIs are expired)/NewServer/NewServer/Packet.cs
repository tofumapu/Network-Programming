using System;
using System.Collections.Generic;
using System.Text;
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
    joinRoom = 6,
    sendBroadcast = 7,
    disconnect = 8, // Đảm bảo packet ID 8 được khai báo
    ping = 9
}
public class Packet
{
    private List<byte> buffer;
    private int readPos;

    public Packet()
    {
        buffer = new List<byte>();
        readPos = 0;
    }

    public Packet(byte[] data)
    {
        buffer = new List<byte>(data);
        readPos = 0;
    }

    public void Write(string value)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(value);
        Write(bytes.Length);
        buffer.AddRange(bytes);
    }

    public string ReadString()
    {
        int length = ReadInt();
        string value = Encoding.UTF8.GetString(buffer.ToArray(), readPos, length);
        readPos += length;
        return value;
    }

    public void Write(int value)
    {
        buffer.AddRange(BitConverter.GetBytes(value));
    }

    public int ReadInt()
    {
        int value = BitConverter.ToInt32(buffer.ToArray(), readPos);
        readPos += 4;
        return value;
    }

    public byte[] ToArray()
    {
        return buffer.ToArray();
    }

    public int Length => buffer.Count;
}
