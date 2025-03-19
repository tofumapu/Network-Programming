using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Lab6_23520231_23520249
{
    public partial class Server : Form
    {
        public Server()
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

private void Listen() // Đón thông điệp từ Client.
{
    int port = Int32.Parse(port_tb.Text);
    server = new UdpClient(port);

    try
    {
        while (true)
        {
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, port);
            byte[] data_byte = server.Receive(ref groupEP);

            // Đọc Key và IV từ TextBox
            string key = tbx_Key.Text; // Lấy Key từ TextBox
            string iv = tbx_IV.Text;   // Lấy IV từ TextBox

            // Kiểm tra độ dài Key và IV
            if (key.Length != 8 || iv.Length != 8)
            {
                MessageBox.Show("Key và IV phải dài 8 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Giải mã thông điệp
            string encryptedData = Encoding.Unicode.GetString(data_byte);
            string decryptedData = DecryptDES(encryptedData, key, iv);

            Invoke((MethodInvoker)delegate
            {
                message_lbx.Items.Add($"Từ {groupEP.Address}:{groupEP.Port}: {decryptedData}{Environment.NewLine}");
            });
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.ToString()); // Thông báo lỗi nếu có.
    }
    finally
    {
        server.Close();
    }
}

        private string DecryptDES(string encryptedText, string key, string iv)
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Key = Encoding.UTF8.GetBytes(key);
                des.IV = Encoding.UTF8.GetBytes(iv);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        byte[] inputBytes = Convert.FromBase64String(encryptedText);
                        cs.Write(inputBytes, 0, inputBytes.Length);
                        cs.FlushFinalBlock();
                        return Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
            }
        }
    }
}
