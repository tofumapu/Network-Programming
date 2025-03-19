using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UDPSocket
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        //private UdpClient udpClient;
        //private bool isListening;

        public void btn_Listen_Click(object sender, EventArgs e)
        {
            //    var ipString = "127.0.0.1";
            //    var ip = IPAddress.Parse(ipString);
            //    var port = Convert.ToInt32(tbx_Input.Text);
            //    try
            //    {
            //        isListening = true;
            //        Thread thdUDPServer = new Thread(() => ServerThread(ip, port));
            //        udpClient = new UdpClient(int.Parse(tbx_Input.Text));
            //        thdUDPServer.IsBackground = true; // Chuyển thread sang chế độ background
            //        thdUDPServer.Start();
            //    }
            //    catch (FormatException)
            //    {
            //        MessageBox.Show("Port không hợp lệ");
            //    }
            //    catch (SocketException)
            //    {
            //        MessageBox.Show("Không thể kết nối đến server");
            //    }
            //    catch { }
            //}

            //private void ServerThread(IPAddress ip, int port)
            //{
            //    while(isListening)
            //    {
            //        try
            //        {
            //            IPEndPoint RemoteIpEndpoint = new IPEndPoint(ip, port);
            //            byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndpoint);
            //            string returnData = Encoding.UTF8.GetString(receiveBytes);
            //            string message = "Message from " + RemoteIpEndpoint.Address + " : " + returnData.ToString();

            //            if (tbx_Output.InvokeRequired)
            //            {
            //                tbx_Output.Invoke(new MethodInvoker(delegate { tbx_Output.Text += message; }));
            //            }
            //            else
            //            {
            //                tbx_Output.Text += message;
            //            }
            //        }
            //        catch (SocketException ex)
            //        {
            //            // Ngắt kết nối
            //            if(isListening && ex.SocketErrorCode != SocketError.Interrupted)
            //            {
            //                throw;
            //            }
            //        }
            //    }    
            //}

            //private void Server_FormClosed(object sender, FormClosedEventArgs e)
            //{
            //    isListening = false;
            //    if(udpClient != null)
            //    {
            //        udpClient.Close();
            //    }
            //}



            int port = Int32.Parse(tbx_Input.Text); // Cổng mặc định

            // Tạo một socket UDP và bind vào cổng
            UdpClient udpClient = new UdpClient(port);

            //Console.WriteLine($"Server đang lắng nghe trên cổng {port}...");

            while (true)
            {
                try
                {
                    // Nhận dữ liệu từ client
                    IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] receiveBytes = udpClient.Receive(ref remoteIpEndPoint);
                    string
                    message = Encoding.ASCII.GetString(receiveBytes);

                    // Hiển thị thông tin về client và tin nhắn nhận được
                    tbx_Output.Text = ($"Nhận được từ {remoteIpEndPoint}: {message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }

            }
        }
    }
}
