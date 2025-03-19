using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_23520231_23520249
{
    public partial class Lab4_BaiTap1 : Form
    {
        public Lab4_BaiTap1()
        {
            InitializeComponent();
        }
        private async void bt_Load_Click(object sender, EventArgs e)
        {
            string url = tb_url.Text;
            if (!url.StartsWith("http://") && !url.StartsWith("https://") && !url.StartsWith("http://localhost"))
            {
                url = "https://" + url;
            }
            if (string.IsNullOrWhiteSpace(url))//Kiểm tra url
            {
                MessageBox.Show("Vui lòng nhập URL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(30);//thời gian chờ

                    HttpResponseMessage response = await client.GetAsync(url);//Gửi HTTP request
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show("Yêu cầu HTTP thành công!");

                    string html = await response.Content.ReadAsStringAsync();//Lấy nội dung HTTP response
                    rtb_HTML.Text = html;

                    GridView_Header.Rows.Clear();//Xóa dữ liệu cũ

                    int stt = 1;

                    //Thêm các header và giá trị vào GridView
                    AddHeaderToGridView(ref stt, "Transfer-Encoding", response.Headers.TransferEncoding?.ToString());
                    AddHeaderToGridView(ref stt, "Connection", response.Headers.Connection?.ToString());
                    AddHeaderToGridView(ref stt, "Vary", string.Join(", ", response.Headers.Vary));
                    AddHeaderToGridView(ref stt, "Link", response.Headers.Contains("Link") ? response.Headers.GetValues("Link").FirstOrDefault() : null);
                    AddHeaderToGridView(ref stt, "X-Frame-Options", response.Headers.Contains("X-Frame-Options") ? response.Headers.GetValues("X-Frame-Options").FirstOrDefault() : null);
                    AddHeaderToGridView(ref stt, "X-Content-Type-Options", response.Headers.Contains("X-Content-Type-Options") ? response.Headers.GetValues("X-Content-Type-Options").FirstOrDefault() : null);
                    AddHeaderToGridView(ref stt, "X-XSS-Protection", response.Headers.Contains("X-XSS-Protection") ? response.Headers.GetValues("X-XSS-Protection").FirstOrDefault() : null);
                    AddHeaderToGridView(ref stt, "Strict-Transport-Security", response.Headers.Contains("Strict-Transport-Security") ? response.Headers.GetValues("Strict-Transport-Security").FirstOrDefault() : null);
                    AddHeaderToGridView(ref stt, "Referrer-Policy", response.Headers.Contains("Referrer-Policy") ? response.Headers.GetValues("Referrer-Policy").FirstOrDefault() : null);
                    AddHeaderToGridView(ref stt, "Cache-Control", response.Headers.CacheControl?.ToString());
                    AddHeaderToGridView(ref stt, "Content-Encoding", string.Join(", ", response.Content.Headers.ContentEncoding));
                    AddHeaderToGridView(ref stt, "Content-Type", response.Content.Headers.ContentType?.ToString());
                    AddHeaderToGridView(ref stt, "Date", response.Headers.Date?.ToString());
                    AddHeaderToGridView(ref stt, "Server", response.Headers.Server?.ToString());
                    AddHeaderToGridView(ref stt, "Content-Length", response.Content.Headers.ContentLength?.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddHeaderToGridView(ref int stt, string headerName, string headerValue)
        {
            if (!string.IsNullOrEmpty(headerValue))//Không hiển thị header hay tăng số thứ tự nếu header rỗng
            {
                GridView_Header.Rows.Add(stt++, headerName, headerValue);
            }
        }

        private void Lab4_BaiTap1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            // Tắt các tiến trình bất đồng bộ(nếu có)
            this.Close();
        }
    }
}
