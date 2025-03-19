using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab5_23520231_23520249
{
    public partial class Lab5_BaiTap2 : Form
    {
        public Lab5_BaiTap2()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var client = new MailKit.Net.Imap.ImapClient();
            client.ServerCertificateValidationCallback = (s, c, h, e) => true;
            client.Connect("127.0.0.1", 993);
            try
            {
                client.Authenticate(tbx_Email.Text, tbx_Password.Text);
            }
            catch (AuthenticationException)
            {
                MessageBox.Show("Lỗi tài khoản hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var inbox = client.Inbox;
            inbox.Open(MailKit.FolderAccess.ReadOnly);
            // Lấy danh sách thư từ hòm thư inbox
            listView.Clear();
            listView.Columns.Add("Email", 400);
            listView.Columns.Add("From", 250);
            listView.Columns.Add("Thời gian", 250);
            listView.View = View.Details;
            // Cập nhật số mail Total và Recent
            lbl_NumTotal.Text = inbox.Count.ToString();
            lbl_NumRecent.Text = inbox.Recent.ToString();
            // Lấy danh sách thư email và sắp xếp theo thời gian gửi
            var sortedMessages = inbox.OrderByDescending(message => message.Date);
            foreach (var message in sortedMessages)
            {
                ListViewItem name = new ListViewItem(message.Subject);

                ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem(name, message.From.ToString());
                name.SubItems.Add(from);

                ListViewItem.ListViewSubItem date = new ListViewItem.ListViewSubItem(name, message.Date.ToString("dd/MM/yyyy HH:mm:ss"));
                name.SubItems.Add(date);

                listView.Items.Add(name);
            }
            client.Disconnect(true);
        }
        private void ReadMail(object sender, EventArgs e)
        {
            var index = listView.FocusedItem.Index;

            var client = new MailKit.Net.Imap.ImapClient();
            client.ServerCertificateValidationCallback = (s, c, h, e_ssl) => true;
            client.Connect("127.0.0.1", 993);
            try
            {
                client.Authenticate(tbx_Email.Text, tbx_Password.Text);
            }
            catch (AuthenticationException)
            {
                MessageBox.Show("Lỗi tài khoản hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy danh sách thư từ hòm thư Inbox
            var inbox = client.Inbox;
            inbox.Open(MailKit.FolderAccess.ReadOnly);

            // Lấy nội dung của email đã chọn
            var message = inbox.GetMessage(index);
            // Hiển thị nội dung HTML của email trong WebBrowser Control
            var webBrowserForm = new Form();
            var webBrowser = new WebBrowser();
            webBrowserForm.Controls.Add(webBrowser);
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.DocumentText = string.IsNullOrEmpty(message.TextBody) ? message.HtmlBody : message.TextBody;
            webBrowserForm.Size = new Size(800, 600);

            webBrowserForm.ShowDialog();

            client.Disconnect(true);
        }
    }
}
