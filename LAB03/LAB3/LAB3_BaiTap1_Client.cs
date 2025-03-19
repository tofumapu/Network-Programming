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
    public partial class LAB3_BaiTap1_Client : Form
    {
        private UdpClient client;
        public LAB3_BaiTap1_Client()
        {
            InitializeComponent();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                client = new UdpClient();
                byte[] sendBytes = Encoding.Unicode.GetBytes(message_tb.Text);

                IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Parse(ip_tb.Text), int.Parse(port_tb.Text));
                client.Send(sendBytes, sendBytes.Length, remoteIpEndPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);// Báo lỗi nếu có.
            }
            finally
            {
                client.Close();
            }
            message_tb.Text = "";// Làm rỗng textbox thông điệp sau khi gửi.
        }
    }
}
