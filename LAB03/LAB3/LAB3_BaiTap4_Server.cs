using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class LAB3_BaiTap4_Server : Form
    {
        public LAB3_BaiTap4_Server()
        {
            InitializeComponent();
        }
        private TcpListener server;
        private Dictionary<TcpClient, string> clients = new Dictionary<TcpClient, string>(); // Lưu trữ client và tên phòng

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int port;
            if (!int.TryParse(textBoxPort.Text, out port))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
            }
            else
            {
                try
                {
                    server = new TcpListener(IPAddress.Any, port);
                    server.Start();
                    Thread listenThread = new Thread(ListenForClients);
                    listenThread.Start();

                    // Update form to show server started successfully
                    Invoke((MethodInvoker)delegate
                    {
                        listBoxMessage.Items.Add($"Server started successfully on port {port}");
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi sử dụng port này " + ex);
                }
            }
        }
        private void ListenForClients()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.Start();
            }
        }
        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;

            try
            {
                //// Nhận tên người dùng từ client
                //bytesRead = stream.Read(buffer, 0, buffer.Length);
                //string username = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                //// Lưu tên người dùng mà không gửi thông báo
                //clients.Add(client, username);

                // Vòng lặp để nhận và gửi tin nhắn
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    string formattedMessage = $"{message}";
                    Invoke((MethodInvoker)delegate
                    {
                        listBoxMessage.Items.Add(formattedMessage);
                    });
                    BroadcastMessage(formattedMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                clients.Remove(client);
            }
            finally
            {
                client.Close();
            }
        }


        private void BroadcastMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            foreach (var pair in clients)
            {
                pair.Key.GetStream().Write(data, 0, data.Length);
            }
        }
        private void SendToClient(TcpClient client, string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            client.GetStream().Write(data, 0, data.Length);
        }
    }
}
