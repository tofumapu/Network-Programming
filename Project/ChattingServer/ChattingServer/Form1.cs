using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChattingServer
{
    public partial class Form1 : Form
    {
        private TcpListener listener;
        private List<ServerClient> clients = new List<ServerClient>();
        private bool isRunning = false;
        string serverIP = "52.65.119.78";
        int port = 6321;

        public Form1()
        {
            InitializeComponent();
            StartServer();
        }

        public class ServerClient
        {
            public TcpClient tcp;
            public string clientName;

            public ServerClient(TcpClient clientSocket)
            {
                tcp = clientSocket;
                clientName = "Khách";
            }
        }

        public void StartServer()
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
                AppendToConnection($"Lỗi khi khởi động server: {ex.Message}\n");
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
                AppendToConnection($"Lỗi khi giải mã domain: {ex.Message}\n");
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
                    ServerClient sc = new ServerClient(client);
                    lock (clients)
                    {
                        clients.Add(sc);
                    }
                    Thread handleClientThread = new Thread(() => HandleClient(sc));
                    handleClientThread.IsBackground = true;
                    handleClientThread.Start();
                }
                catch (Exception ex)
                {
                    AppendToConnection($"Lỗi khi chấp nhận client: {ex.Message}\n");
                }
            }
        }

        private void HandleClient(ServerClient sc)
        {
            NetworkStream stream = sc.tcp.GetStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            StreamWriter writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };

            try
            {
                // Nhận tên từ Client
                string nameMessage = reader.ReadLine();
                if (nameMessage != null && nameMessage.StartsWith("NAME:"))
                {
                    sc.clientName = nameMessage.Substring(5).Trim();
                    AppendToConnection($"{sc.clientName} đã kết nối.\n");
                    BroadcastToAllClients($"BROADCAST_SUCCESS:{sc.clientName} đã tham gia chat.");
                }

                // Nhận và Broadcast tin nhắn
                string message;
                while ((message = reader.ReadLine()) != null)
                {
                    if (message.StartsWith("ROOM_MSG:"))
                    {
                        string chatMessage = message.Substring(9).Trim();
                        string broadcastMessage = $"BROADCAST_SUCCESS:{sc.clientName}: {chatMessage}";
                        BroadcastToAllClients(broadcastMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                AppendToConnection($"Lỗi với client {sc.clientName}: {ex.Message}\n");
            }
            finally
            {
                lock (clients)
                {
                    clients.Remove(sc);
                }
                sc.tcp.Close();
                AppendToConnection($"{sc.clientName} đã ngắt kết nối.\n");
                BroadcastToAllClients($"BROADCAST_SUCCESS:{sc.clientName} đã rời khỏi chat.");
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
                        StreamWriter writer = new StreamWriter(client.tcp.GetStream(), Encoding.UTF8) { AutoFlush = true };
                        writer.WriteLine(message); // Gửi thông điệp với \n
                    }
                    catch (Exception ex)
                    {
                        AppendToConnection($"Lỗi khi gửi tin nhắn tới {client.clientName}: {ex.Message}\n");
                    }
                }
            }
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
    }
}
