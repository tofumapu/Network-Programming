using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Lab5_23520231_23520249
{
    public partial class Lab5_BaiTap1 : Form
    {
        public Lab5_BaiTap1()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = tbx_EmailFrom.Text.ToString().Trim();
                string mailto = tbx_EmailTo.Text.ToString().Trim();
                string password = tbx_InputPassword.Text.ToString().Trim();
                var basicCredential = new System.Net.NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;


                    message.From = fromAddress;
                    message.Subject = rtbx_Subject.Text.ToString().Trim();
                    string body = rtbx_Body.Text.ToString().Trim();
                    string htmlBody = body.Replace("\n", "<br>"); // Chuyển đổi ký tự '\n' thành <br>
                    message.Body = htmlBody;
                    message.IsBodyHtml = true;
                    
                    message.To.Add(tbx_EmailTo.Text);
                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Email sent successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi không xác định", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
