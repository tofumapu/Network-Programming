namespace Lab4_23520231_23520249
{
    partial class Lab4_BaiTap4
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox tbx_URL;
        private Button btn_LoadPage;
        private ComboBox cbx_UserAgent;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab4_BaiTap4));
            tbx_URL = new TextBox();
            btn_LoadPage = new Button();
            cbx_UserAgent = new ComboBox();
            webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            toolStrip1 = new ToolStrip();
            toolStriptbx_CurrentURL = new ToolStripTextBox();
            toolStripbtn_Reload = new ToolStripButton();
            toolStripDownload_HTML = new ToolStripButton();
            toolStripbtn_DownloadAll = new ToolStripButton();
            toolStripbtn_Source = new ToolStripButton();
            toolStripButtonbtn_ResponseHeader = new ToolStripButton();
            lbl_UserAgent = new Label();
            lbl_URL = new Label();
            ((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbx_URL
            // 
            tbx_URL.Location = new Point(137, 12);
            tbx_URL.Name = "tbx_URL";
            tbx_URL.PlaceholderText = "Nhập URL...";
            tbx_URL.Size = new Size(957, 35);
            tbx_URL.TabIndex = 0;
            // 
            // btn_LoadPage
            // 
            btn_LoadPage.Location = new Point(1496, 15);
            btn_LoadPage.Name = "btn_LoadPage";
            btn_LoadPage.Size = new Size(168, 63);
            btn_LoadPage.TabIndex = 1;
            btn_LoadPage.Text = "Duyệt";
            btn_LoadPage.Click += btn_LoadPage_Click;
            // 
            // cbx_UserAgent
            // 
            cbx_UserAgent.Location = new Point(137, 62);
            cbx_UserAgent.Name = "cbx_UserAgent";
            cbx_UserAgent.Size = new Size(625, 38);
            cbx_UserAgent.TabIndex = 2;
            // 
            // webView2
            // 
            webView2.AllowExternalDrop = true;
            webView2.CreationProperties = null;
            webView2.DefaultBackgroundColor = Color.White;
            webView2.Dock = DockStyle.Bottom;
            webView2.Location = new Point(0, 152);
            webView2.Name = "webView2";
            webView2.Size = new Size(1676, 864);
            webView2.TabIndex = 3;
            webView2.ZoomFactor = 1D;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(28, 28);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStriptbx_CurrentURL, toolStripbtn_Reload, toolStripDownload_HTML, toolStripbtn_DownloadAll, toolStripbtn_Source, toolStripButtonbtn_ResponseHeader });
            toolStrip1.Location = new Point(0, 114);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1676, 38);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStriptbx_CurrentURL
            // 
            toolStriptbx_CurrentURL.Name = "toolStriptbx_CurrentURL";
            toolStriptbx_CurrentURL.Size = new Size(1300, 38);
            // 
            // toolStripbtn_Reload
            // 
            toolStripbtn_Reload.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripbtn_Reload.Image = (Image)resources.GetObject("toolStripbtn_Reload.Image");
            toolStripbtn_Reload.ImageTransparentColor = Color.Magenta;
            toolStripbtn_Reload.Name = "toolStripbtn_Reload";
            toolStripbtn_Reload.Size = new Size(40, 32);
            toolStripbtn_Reload.Text = "Reload";
            toolStripbtn_Reload.Click += toolStripbtn_Reload_Click;
            // 
            // toolStripDownload_HTML
            // 
            toolStripDownload_HTML.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDownload_HTML.Image = (Image)resources.GetObject("toolStripDownload_HTML.Image");
            toolStripDownload_HTML.ImageTransparentColor = Color.Magenta;
            toolStripDownload_HTML.Name = "toolStripDownload_HTML";
            toolStripDownload_HTML.Size = new Size(40, 32);
            toolStripDownload_HTML.Text = "View as HTML";
            toolStripDownload_HTML.Click += toolStripDownload_HTML_Click;
            // 
            // toolStripbtn_DownloadAll
            // 
            toolStripbtn_DownloadAll.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripbtn_DownloadAll.Image = (Image)resources.GetObject("toolStripbtn_DownloadAll.Image");
            toolStripbtn_DownloadAll.ImageTransparentColor = Color.Magenta;
            toolStripbtn_DownloadAll.Name = "toolStripbtn_DownloadAll";
            toolStripbtn_DownloadAll.Size = new Size(40, 32);
            toolStripbtn_DownloadAll.Text = "Download All Source";
            toolStripbtn_DownloadAll.Click += toolStripbtn_DownloadAll_Click;
            // 
            // toolStripbtn_Source
            // 
            toolStripbtn_Source.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripbtn_Source.Image = (Image)resources.GetObject("toolStripbtn_Source.Image");
            toolStripbtn_Source.ImageTransparentColor = Color.Magenta;
            toolStripbtn_Source.Name = "toolStripbtn_Source";
            toolStripbtn_Source.Size = new Size(40, 32);
            toolStripbtn_Source.Text = "View Source";
            toolStripbtn_Source.Click += toolStripbtn_Source_Click;
            // 
            // toolStripButtonbtn_ResponseHeader
            // 
            toolStripButtonbtn_ResponseHeader.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonbtn_ResponseHeader.Image = (Image)resources.GetObject("toolStripButtonbtn_ResponseHeader.Image");
            toolStripButtonbtn_ResponseHeader.ImageTransparentColor = Color.Magenta;
            toolStripButtonbtn_ResponseHeader.Name = "toolStripButtonbtn_ResponseHeader";
            toolStripButtonbtn_ResponseHeader.Size = new Size(40, 32);
            toolStripButtonbtn_ResponseHeader.Text = "Response Header";
            toolStripButtonbtn_ResponseHeader.Click += toolStripButtonbtn_ResponseHeader_Click;
            // 
            // lbl_UserAgent
            // 
            lbl_UserAgent.AutoSize = true;
            lbl_UserAgent.Location = new Point(26, 65);
            lbl_UserAgent.Name = "lbl_UserAgent";
            lbl_UserAgent.Size = new Size(105, 30);
            lbl_UserAgent.TabIndex = 5;
            lbl_UserAgent.Text = "Nền tảng:";
            // 
            // lbl_URL
            // 
            lbl_URL.AutoSize = true;
            lbl_URL.Location = new Point(26, 15);
            lbl_URL.Name = "lbl_URL";
            lbl_URL.Size = new Size(55, 30);
            lbl_URL.TabIndex = 6;
            lbl_URL.Text = "URL:";
            // 
            // Lab4_BaiTap4
            // 
            ClientSize = new Size(1676, 1016);
            Controls.Add(lbl_URL);
            Controls.Add(lbl_UserAgent);
            Controls.Add(toolStrip1);
            Controls.Add(tbx_URL);
            Controls.Add(btn_LoadPage);
            Controls.Add(cbx_UserAgent);
            Controls.Add(webView2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Lab4_BaiTap4";
            Text = "Lab4_BaiTap4";
            FormClosed += Lab4_BaiTap4_FormClosed;
            ((System.ComponentModel.ISupportInitialize)webView2).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ToolStrip toolStrip1;
        private ToolStripTextBox toolStriptbx_CurrentURL;
        private ToolStripButton toolStripbtn_Reload;
        private ToolStripButton toolStripDownload_HTML;
        private ToolStripButton toolStripbtn_DownloadAll;
        private ToolStripButton toolStripbtn_Source;
        private Label lbl_UserAgent;
        private Label lbl_URL;
        private ToolStripButton toolStripButtonbtn_ResponseHeader;
    }
}
