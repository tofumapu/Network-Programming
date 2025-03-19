using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class LAB3_BaiTap2 : Form
    {
        public LAB3_BaiTap2()
        {
            InitializeComponent();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            // Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(ServerThread));
            serverThread.Start();
        }
        void ServerThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            Socket clientSocket = null; // Khởi tạo socket client
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listener.Bind(ipEnd);
            listener.Listen(-1);
            clientSocket = listener.Accept();
            rtb_Output.Text += "Connected\n";
            bool isConnected = true;
            while (clientSocket.Connected && isConnected)
            {
                string text = "";
                do
                {
                    try
                    {
                        bytesReceived = clientSocket.Receive(recv);
                        if (bytesReceived == 0) // Kiểm tra nếu client bị ngắt kết nối
                        {
                            isConnected = false;
                            break; // Thoát khỏi vòng lặp
                        }
                        text += Encoding.ASCII.GetString(recv);
                    }
                    catch (InvalidOperationException ex)
                    {
                        // Xử lý lỗi InvalidOperationException
                        Console.WriteLine("Error: " + ex.Message);
                    }
                } while (text[text.Length - 1] != '\n');

                if (isConnected == false)
                {
                    rtb_Output.Text += "Client disconnected\n";
                    break;
                }
                else
                {
                    rtb_Output.Text += text;
                }
            }
        }
    }
}
