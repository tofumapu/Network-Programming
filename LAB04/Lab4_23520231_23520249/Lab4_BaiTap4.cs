using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using static System.Windows.Forms.LinkLabel;
using HtmlAgilityPack;
using System.Net;
using System.Net.Http;
using System.Security.Policy;

namespace Lab4_23520231_23520249
{
    public partial class Lab4_BaiTap4 : Form
    {
        public Lab4_BaiTap4()
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

            // Đăng ký sự kiện SourceChanged
            webView2.CoreWebView2.SourceChanged += CoreWebView2_SourceChanged;
        }
        private void CoreWebView2_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            if (webView2.CoreWebView2 != null)
            {
                // Cập nhật URL hiện tại vào toolStriptbx_CurrentURL
                toolStriptbx_CurrentURL.Text = webView2.CoreWebView2.Source;
            }
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
        private void InitializeUserAgentComboBox()
        {
            cbx_UserAgent.DataSource = new BindingSource(userAgentList, null);
            cbx_UserAgent.DisplayMember = "Key";
            cbx_UserAgent.ValueMember = "Value";
        }
        private async void btn_LoadPage_Click(object sender, EventArgs e)
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
            string selectedUserAgent = ((KeyValuePair<string, string>?)cbx_UserAgent.SelectedItem)?.Value ?? string.Empty;
            webView2.CoreWebView2.Settings.UserAgent = selectedUserAgent;

            // Điều hướng đến URL
            webView2.CoreWebView2.Navigate(url);
            // Cập nhật URL lên ToolStripTextBox
            webView2.CoreWebView2.NavigationCompleted += (s, e) =>
            {
                toolStriptbx_CurrentURL.Text = webView2.CoreWebView2.Source;
            };
        }
        private void toolStripbtn_Reload_Click(object sender, EventArgs e) // Cho phép reload lại trang web
        {
            string url = toolStriptbx_CurrentURL.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            webView2.CoreWebView2.Reload();
        }
        private string DownloadPageSource(string url)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(url);
            }
        }
        private void SaveHtmlToFile(string htmlContent)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*",
                FileName = "source.html"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, htmlContent);
            }
        }
        private void DownloadFile(string url)
        {
            using (WebClient client = new WebClient())
            {
                string fileName = Path.GetFileName(url);
                string downloadPath = Path.Combine(Application.StartupPath, fileName);
                client.DownloadFile(url, downloadPath);
            }
        }
        private void toolStripDownload_HTML_Click(object sender, EventArgs e) // Cho phép download HTML của trang web
        {

            string url = toolStriptbx_CurrentURL.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                if (string.IsNullOrEmpty(url))
                {
                    MessageBox.Show("Vui lòng nhập URL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
            }

            // Tải mã nguồn HTML của trang
            string htmlContent = DownloadPageSource(url);

            // Lưu mã nguồn HTML vào file
            SaveHtmlToFile(htmlContent);
            MessageBox.Show("Tải xong mã nguồn HTML!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private async void toolStripbtn_DownloadAll_Click(object sender, EventArgs e)
        {
            string url = toolStriptbx_CurrentURL.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
            }

            try
            {
                // Tạo thư mục lưu trữ
                string folderPath = CreateSaveFolder(url);

                // Tải mã nguồn HTML
                string htmlContent = DownloadPageSource(url);

                // Tải và lưu tài nguyên, đồng thời cập nhật lại đường dẫn
                string updatedHtml = await ExtractAndSaveResources(url, htmlContent, folderPath);

                // Lưu mã nguồn HTML đã cập nhật
                string htmlFilePath = Path.Combine(folderPath, "index.html");
                File.WriteAllText(htmlFilePath, updatedHtml);

                MessageBox.Show($"Tải xong toàn bộ tài nguyên và lưu tại: {folderPath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string CreateSaveFolder(string baseUrl)
        {
            string domain = new Uri(baseUrl).Host.Replace("www.", "");
            string folderName = $"{domain}_{DateTime.Now:yyyyMMdd_HHmmss}";
            string folderPath = Path.Combine(Application.StartupPath, folderName);

            Directory.CreateDirectory(folderPath);
            Directory.CreateDirectory(Path.Combine(folderPath, "css"));
            Directory.CreateDirectory(Path.Combine(folderPath, "js"));
            Directory.CreateDirectory(Path.Combine(folderPath, "images"));

            return folderPath;
        }
        private async Task<string> ExtractAndSaveResources(string baseUrl, string htmlContent, string folderPath)
        {
            var baseUri = new Uri(baseUrl);
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(htmlContent);

            // Lưu CSS
            var cssNodes = doc.DocumentNode.SelectNodes("//link[@rel='stylesheet' and @href]");
            if (cssNodes != null)
            {
                foreach (var node in cssNodes)
                {
                    string href = node.GetAttributeValue("href", string.Empty);
                    string absoluteUrl = new Uri(baseUri, href).ToString();
                    string fileName = Path.GetFileName(new Uri(absoluteUrl).LocalPath);
                    string savePath = Path.Combine(folderPath, "css", fileName);

                    if (await DownloadResourceAsync(absoluteUrl, savePath))
                        node.SetAttributeValue("href", $"css/{fileName}");
                }
            }

            // Lưu JS
            var jsNodes = doc.DocumentNode.SelectNodes("//script[@src]");
            if (jsNodes != null)
            {
                foreach (var node in jsNodes)
                {
                    string src = node.GetAttributeValue("src", string.Empty);
                    string absoluteUrl = new Uri(baseUri, src).ToString();
                    string fileName = Path.GetFileName(new Uri(absoluteUrl).LocalPath);
                    string savePath = Path.Combine(folderPath, "js", fileName);

                    if (await DownloadResourceAsync(absoluteUrl, savePath))
                        node.SetAttributeValue("src", $"js/{fileName}");
                }
            }

            // Lưu Images
            var imgNodes = doc.DocumentNode.SelectNodes("//img[@src]");
            if (imgNodes != null)
            {
                foreach (var node in imgNodes)
                {
                    string src = node.GetAttributeValue("src", string.Empty);
                    string absoluteUrl = new Uri(baseUri, src).ToString();
                    string fileName = Path.GetFileName(new Uri(absoluteUrl).LocalPath);
                    string savePath = Path.Combine(folderPath, "images", fileName);

                    if (await DownloadResourceAsync(absoluteUrl, savePath))
                        node.SetAttributeValue("src", $"images/{fileName}");
                }
            }

            // Trả về mã HTML đã cập nhật đường dẫn
            return doc.DocumentNode.OuterHtml;
        }
        private async Task<bool> DownloadResourceAsync(string resourceUrl, string savePath)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] data = await client.GetByteArrayAsync(resourceUrl);
                    await File.WriteAllBytesAsync(savePath, data);
                    return true;
                }
            }
            catch
            {
                return false; // Bỏ qua nếu lỗi
            }
        }

        private void toolStripbtn_Source_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";
                openFileDialog.Title = "Chọn tệp HTML";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Hiển thị tệp HTML trong WebView2
                    DisplayHtmlInWebView(filePath);
                }
            }
        }
        private void DisplayHtmlInWebView(string htmlFilePath)
        {
            if (webView2.CoreWebView2 != null)
            {
                // Lấy đường dẫn thư mục chứa HTML
                string folderPath = Path.GetDirectoryName(htmlFilePath);

                // Thiết lập quyền truy cập tài nguyên cục bộ
                webView2.CoreWebView2.SetVirtualHostNameToFolderMapping(
                    "localresources",
                    folderPath,
                    CoreWebView2HostResourceAccessKind.Allow);

                // Điều hướng đến tệp HTML
                string virtualPath = $"https://localresources/{Path.GetFileName(htmlFilePath)}";
                webView2.CoreWebView2.Navigate(virtualPath);
            }
            else
            {
                MessageBox.Show("WebView2 chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task GetResponseHeaders(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Thực hiện GET request
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Lấy các Header trong Response
                    var headers = response.Headers;
                    var contentHeaders = response.Content.Headers;

                    // Hiển thị Header trong MessageBox
                    string headerInfo = "Response Headers:\n";
                    foreach (var header in headers)
                    {
                        headerInfo += $"{header.Key}: {string.Join(", ", header.Value)}\n";
                    }

                    headerInfo += "\nContent Headers:\n";
                    foreach (var contentHeader in contentHeaders)
                    {
                        headerInfo += $"{contentHeader.Key}: {string.Join(", ", contentHeader.Value)}\n";
                    }

                    MessageBox.Show(headerInfo, "Response Headers");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async void toolStripButtonbtn_ResponseHeader_Click(object sender, EventArgs e)
        {
            string url = toolStriptbx_CurrentURL.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Hiển thị Header Response
            await GetResponseHeaders(url);
        }
        private void Lab4_BaiTap4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
