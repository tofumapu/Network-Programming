using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LAB3
{
    public partial class LAB3_BaiTap4_Client : Form
    {
        private string username;
        private TcpClient client;
        private NetworkStream stream;
        private BackgroundWorker bgWorker;
        public LAB3_BaiTap4_Client()
        {
            InitializeComponent();
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += BgWorker_DoWork;
            ConnectToServer("localhost", 8080);

            // Prompt user for a username
            //username = Microsoft.VisualBasic.Interaction.InputBox("Enter your name:", "Username", "Guest");
            if (!string.IsNullOrEmpty(username) && stream != null)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(username);
                stream.Write(buffer, 0, buffer.Length);
            }
        }
        private void ConnectToServer(string server, int port)
        {
            try
            {
                client = new TcpClient(server, port);
                stream = client.GetStream();
                bgWorker.RunWorkerAsync(); // Bắt đầu nhận dữ liệu từ server
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                try
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        // Kết nối bị ngắt
                        break;
                    }
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // Cập nhật giao diện trên thread chính
                    this.Invoke((MethodInvoker)delegate
                    {
                        listBoxMessages.Items.Add(message);
                    });
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi đọc dữ liệu
                    MessageBox.Show("Lỗi nhận dữ liệu: " + ex.Message);
                    break;
                }
            }
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            username = nameTb.Text.ToString();
            string message = $"{username}: {textBoxMessage.Text}";
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream.Write(buffer, 0, buffer.Length);
            textBoxMessage.Clear();
        }
    }
}
