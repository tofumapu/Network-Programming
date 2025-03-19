using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using static System.Windows.Forms.LinkLabel;

namespace Lab4_23520231_23520249
{
    public partial class Lab4_BaiTap2 : Form
    {
        public Lab4_BaiTap2()
        {
            InitializeComponent();
            InitializeUserAgentComboBox();
            InitializeWebView2();
        }

        private async void InitializeWebView2()
        {
            // Khởi tạo WebView2
            await webView2.EnsureCoreWebView2Async();
            webView2.CoreWebView2.Settings.UserAgent = userAgentList["Safari 17.6, Mac OS X"]; // Default User-Agent
        }

        private Dictionary<string, string> userAgentList = new Dictionary<string, string>()
        {
            { "Safari 17.6, Mac OS X", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/17.6 Safari/605.1.1" },
            { "Chrome - Android Mobile", "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Mobile Safari/537.36" },
            { "Chrome - Android Mobile (high-end)", "Mozilla/5.0 (Linux; Android 10; Pixel 4) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Mobile Safari/537.36" },
            { "Chrome - Android Tablet", "Mozilla/5.0 (Linux; Android 4.3; Nexus 7 Build/JSS15Q) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36" },
            { "Chrome - iPhone", "Mozilla/5.0 (iPhone; CPU iPhone OS 13_2 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) CriOS/131.0.0.0 Mobile/15E148 Safari/604.1" },
            { "Chrome - iPad", "Mozilla/5.0 (iPad; CPU OS 13_2 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) CriOS/131.0.0.0 Mobile/15E148 Safari/604.1" },
            { "Chrome - Chrome OS", "Mozilla/5.0 (X11; CrOS x86_64 10066.0.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36" },
            { "Chrome - Mac", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36" },
            { "Chrome - Windows", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36" },
            { "Microsoft Edge (Chromium) - Windows", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36 Edg/131.0.0.0" },
            { "Microsoft Edge (Chromium) - Mac", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/605.1.15 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/604.1 Edg/131.0.0.0" },
            { "Microsoft Edge - iPhone", "Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 EdgiOS/44.5.0.10 Mobile/15E148 Safari/604.1" },
            { "Microsoft Edge - iPad", "Mozilla/5.0 (iPad; CPU OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.0 EdgiOS/44.5.2 Mobile/15E148 Safari/605.1.15" },
            { "Microsoft Edge - Android Mobile", "Mozilla/5.0 (Linux; Android 8.1.0; Pixel Build/OPM4.171019.021.D1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.109 Mobile Safari/537.36 EdgA/42.0.0.2057" },
            { "Microsoft Edge - Android Tablet", "Mozilla/5.0 (Linux; Android 6.0.1; Nexus 7 Build/MOB30X) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.109 Safari/537.36 EdgA/42.0.0.2057" },
            { "Microsoft Edge (EdgeHTML) - Windows", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36 Edge/18.19042" },
            { "Microsoft Edge (EdgeHTML) - Xbox", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; Xbox; Xbox One) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36 Edge/18.19041" },
            { "Opera - Mac", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48" },
            { "Opera - Windows", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48" },
            { "Safari - iPad iOS 13.2", "Mozilla/5.0 (iPad; CPU iPhone OS 13_2_3 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.0.3 Mobile/15E148 Safari/604.1" },
            { "Safari - iPhone iOS 13.2", "Mozilla/5.0 (iPhone; CPU iPhone OS 13_2_3 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.0.3 Mobile/15E148 Safari/604.1" },
            { "Safari - Mac", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.0.3 Safari/605.1.15" },
            { "Android (4.0.2) Browser - Galaxy Nexus", "Mozilla/5.0 (Linux; U; Android 4.0.2; en-us; Galaxy Nexus Build/ICL53F) AppleWebKit/534.30 (KHTML, like Gecko) Version/4.0 Mobile Safari/534.30" },
            { "Android (2.3) Browser - Nexus 5", "Mozilla/5.0 (Linux; U; Android 2.3.6; en-us; Nexus S Build/GRK39F) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1" },
            { "BlackBerry - BB10", "Mozilla/5.0 (BB10; Touch) AppleWebKit/537.1+ (KHTML, like Gecko) Version/10.0.0.1337 Mobile Safari/537.1+" },
            { "BlackBerry - PlayBook 2.1", "Mozilla/5.0 (PlayBook; U; RIM Tablet OS 2.1.0; en-US) AppleWebKit/536.2+ (KHTML, like Gecko) Version/7.2.1.0 Safari/536.2+" },
            { "BlackBerry - 9900", "Mozilla/5.0 (BlackBerry; U; BlackBerry 9900; en-US) AppleWebKit/534.11+ (KHTML, like Gecko) Version/7.0.0.187 Mobile Safari/534.11+" }
        };
        private Dictionary<string, (int Width, int Height)> userAgentSizes = new Dictionary<string, (int Height, int Width)>()
        {
            { "Safari 17.6, Mac OS X", (1200, 800) },
            { "Chrome - Android Mobile", (480, 800) },
            { "Chrome - Android Mobile (high-end)", (720, 1280) },
            { "Chrome - Android Tablet", (800, 1280) },
            { "Chrome - iPhone", (375, 667) },
            { "Chrome - iPad", (768, 1024) },
            { "Chrome - Chrome OS", (1366, 768) },
            { "Chrome - Mac", (1280, 800) },
            { "Chrome - Windows", (1366, 768) },
            { "Microsoft Edge (Chromium) - Windows", (1366, 768) },
            { "Microsoft Edge (Chromium) - Mac", (1280, 800) },
            { "Microsoft Edge - iPhone", (375, 667) },
            { "Microsoft Edge - iPad", (768, 1024) },
            { "Microsoft Edge - Android Mobile", (480, 800) },
            { "Microsoft Edge - Android Tablet", (800, 1280) },
            { "Microsoft Edge (EdgeHTML) - Windows", (1366, 768) },
            { "Microsoft Edge (EdgeHTML) - Xbox", (1920, 1080) },
            { "Opera - Mac", (1280, 800) },
            { "Opera - Windows", (1366, 768) },
            { "Safari - iPad iOS 13.2", (768, 1024) },
            { "Safari - iPhone iOS 13.2", (375, 667) },
            { "Safari - Mac", (1200, 800) },
            { "Android (4.0.2) Browser - Galaxy Nexus", (480, 800) },
            { "Android (2.3) Browser - Nexus 5", (320, 480) },
            { "BlackBerry - BB10", (720, 720) },
            { "BlackBerry - PlayBook 2.1", (600, 1024) },
            { "BlackBerry - 9900", (480, 640) }
        };

        private void InitializeUserAgentComboBox()
        {
            cbx_UserAgent.DataSource = new BindingSource(userAgentList, null);
            cbx_UserAgent.DisplayMember = "Key";
            cbx_UserAgent.ValueMember = "Value";
        }

        private void btn_LoadPage_Click(object sender, EventArgs e)
        {
            string url = tbx_URL.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
            }

            // Cập nhật User-Agent
            string selectedUserAgent = ((KeyValuePair<string, string>)cbx_UserAgent.SelectedItem).Value;
            webView2.CoreWebView2.Settings.UserAgent = selectedUserAgent;

            // Điều chỉnh kích thước WebView2
            string selectedKey = ((KeyValuePair<string, string>)cbx_UserAgent.SelectedItem).Key;
            if (userAgentSizes.TryGetValue(selectedKey, out var size))
            {
                webView2.Width = (int)((size.Width / 1896.0) * 1896);
                webView2.Height = (int)((size.Height / 834.0) * 834);
            }

            // Điều hướng đến URL
            webView2.CoreWebView2.Navigate(url);
        }

        private void Lab4_BaiTap2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
