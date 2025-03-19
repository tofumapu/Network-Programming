namespace Lab4_23520231_23520249
{
    partial class Lab4_BaiTap2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab4_BaiTap2));
            tbx_URL = new TextBox();
            btn_LoadPage = new Button();
            cbx_UserAgent = new ComboBox();
            webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
            SuspendLayout();
            // 
            // tbx_URL
            // 
            tbx_URL.Location = new Point(29, 33);
            tbx_URL.Name = "tbx_URL";
            tbx_URL.PlaceholderText = "Nhập URL...";
            tbx_URL.Size = new Size(957, 35);
            tbx_URL.TabIndex = 0;
            // 
            // btn_LoadPage
            // 
            btn_LoadPage.Location = new Point(1002, 33);
            btn_LoadPage.Name = "btn_LoadPage";
            btn_LoadPage.Size = new Size(252, 71);
            btn_LoadPage.TabIndex = 1;
            btn_LoadPage.Text = "Load";
            btn_LoadPage.Click += btn_LoadPage_Click;
            // 
            // cbx_UserAgent
            // 
            cbx_UserAgent.Location = new Point(29, 90);
            cbx_UserAgent.Name = "cbx_UserAgent";
            cbx_UserAgent.Size = new Size(625, 38);
            cbx_UserAgent.TabIndex = 2;
            // 
            // webView2
            // 
            webView2.AllowExternalDrop = true;
            webView2.CreationProperties = null;
            webView2.DefaultBackgroundColor = Color.White;
            webView2.Location = new Point(0, 167);
            webView2.Name = "webView2";
            webView2.Size = new Size(1254, 849);
            webView2.TabIndex = 3;
            webView2.ZoomFactor = 1D;
            // 
            // Lab4_BaiTap2
            // 
            ClientSize = new Size(1255, 1016);
            Controls.Add(tbx_URL);
            Controls.Add(btn_LoadPage);
            Controls.Add(cbx_UserAgent);
            Controls.Add(webView2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Lab4_BaiTap2";
            Text = "Lab4_BaiTap2";
            FormClosed += Lab4_BaiTap2_FormClosed;
            ((System.ComponentModel.ISupportInitialize)webView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
