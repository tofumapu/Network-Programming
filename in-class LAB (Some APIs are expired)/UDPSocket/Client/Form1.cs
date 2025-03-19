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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Send_bt_Click(object sender, EventArgs e)
        {
            //{
            //    try
            //    {
            //        using (UdpClient udpClient = new UdpClient())
            //        {
            //            //Lấy địa chỉ IP từ textbox và chuyển thành kiểu IPAddress
            //            IPAddress ipadd = IPAddress.Parse(IP_tb.Text);
            //            int port = Convert.ToInt32(Port_tb.Text);
            //            IPEndPoint ipend = new IPEndPoint(ipadd, port);
            //            //Chuyển chuỗi dữ liệu nhập sang kiểu byte
            //            Byte[] sendBytes = Encoding.UTF8.GetBytes(Message_rtb.Text);
            //            //Gởi dữ liệu đến IPEndPoint đã định nghĩa địa chỉ IP và Port
            //            udpClient.Send(sendBytes, sendBytes.Length, Message_rtb.Text, 8080);
            //        }
            //        //Xóa dữ liệu vừa gửi ở ô nhập
            //        Message_rtb.Text = "";
            //    }
            //    catch(SocketException)
            //    {
            //        MessageBox.Show("Không thể kết nối đến server");
            //    }
            //    catch(FormatException)
            //    {
            //        MessageBox.Show("Địa chỉ IP hoặc Port không hợp lệ");
            //    }
            //    catch { }

            UdpClient udpClient = new UdpClient();
            string data = data_tb.Text;
            byte[] sendBytes = Encoding.ASCII.GetBytes(data);
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(IP_tb.Text), int.Parse(Port_tb.Text));
            udpClient.Send(sendBytes, sendBytes.Length, ipEndPoint);
        }
    }
}
