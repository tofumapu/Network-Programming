using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_23520231_23520249
{
    public partial class Client : Form
    {
        private UdpClient client;
        public Client()
        {
            InitializeComponent();
        }
        private string EncryptDES(string plainText, string key, string iv)
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Key = Encoding.UTF8.GetBytes(key);
                des.IV = Encoding.UTF8.GetBytes(iv);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] inputBytes = Encoding.Unicode.GetBytes(plainText);
                        cs.Write(inputBytes, 0, inputBytes.Length);
                        cs.FlushFinalBlock();
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string key = tbx_Key.Text; // Lấy Key từ TextBox
                string iv = tbx_IV.Text;   // Lấy IV từ TextBox

                // Kiểm tra độ dài Key và IV
                if (key.Length != 8 || iv.Length != 8)
                {
                    MessageBox.Show("Key và IV phải dài 8 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                client = new UdpClient();

                // Mã hóa thông điệp
                string encryptedMessage = EncryptDES(message_tb.Text, key, iv);
                byte[] sendBytes = Encoding.Unicode.GetBytes(encryptedMessage);

                IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Parse(ip_tb.Text), int.Parse(port_tb.Text));
                client.Send(sendBytes, sendBytes.Length, remoteIpEndPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message); // Báo lỗi nếu có.
            }
            finally
            {
                client.Close();
            }
            message_tb.Text = ""; // Làm rỗng textbox thông điệp sau khi gửi.
        }

    }
}
