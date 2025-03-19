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
    public partial class LAB3_BaiTap3_Client : Form
    {
        public LAB3_BaiTap3_Client()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        TcpClient tcpClient;
        IPEndPoint iPEndPoint;
        NetworkStream stream;
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            tcpClient = new TcpClient();
            tcpClient.Connect(iPEndPoint);
            stream = tcpClient.GetStream();

            byte[] data = Encoding.UTF8.GetBytes("Hello Server" +
                " ");
            stream.Write(data, 0, data.Length);
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tin nhắn tùy ý từ rtb_message
                string message = rtb_Input.Text;
                rtb_Input.Clear();
                rtb_Output.Text += message + "\n";
                byte[] data = Encoding.UTF8.GetBytes("Client: " + message + "\n");
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] data = System.Text.Encoding.UTF8.GetBytes("Client Quit!\n");
                stream.Write(data, 0, data.Length);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Bai3_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Byte[] data = System.Text.Encoding.UTF8.GetBytes("Quit\n");
            stream.Write(data, 0, data.Length);
            this.Hide();
        }
    }
}
