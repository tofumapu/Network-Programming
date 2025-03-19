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
    public partial class LAB3_BaiTap1_Server : Form
    {
        public LAB3_BaiTap1_Server()
        {
            InitializeComponent();
        }
        private UdpClient server;
        private IPEndPoint endpoint;

        private void listen_Click(object sender, EventArgs e)// Tạo thread để nhận thông điệp.
        {
            Thread listenThread = new Thread(Listen);
            listenThread.Start();
        }

        private void Listen()// Đón thông điệp từ Client.
        {
            int port = Int32.Parse(port_tb.Text);
            server = new UdpClient(port);

            try
            {
                while (true)
                {
                    IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, port);
                    byte[] data_byte = server.Receive(ref groupEP);
                    string data = Encoding.Unicode.GetString(data_byte);
                    Invoke((MethodInvoker)delegate
                    {
                        message_lbx.Items.Add($"Từ {groupEP.Address}:{groupEP.Port}: {data}{Environment.NewLine}");// Hiển thị thông điệp gửi từ Client.
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());// Thông báo lỗi nếu có. 
            }
            finally
            {
                server.Close();
            }
        }
    }
}
