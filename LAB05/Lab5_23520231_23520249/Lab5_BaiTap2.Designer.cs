namespace Lab5_23520231_23520249
{
    partial class Lab5_BaiTap2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab5_BaiTap2));
            lbl_Email = new Label();
            lbl_Password = new Label();
            textBox1 = new TextBox();
            tbx_Password = new TextBox();
            btn_Login = new Button();
            lbl_Total = new Label();
            lbl_NumTotal = new Label();
            lbl_Recent = new Label();
            lbl_NumRecent = new Label();
            listView = new ListView();
            tbx_Email = new TextBox();
            SuspendLayout();
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(34, 32);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(68, 30);
            lbl_Email.TabIndex = 0;
            lbl_Email.Text = "Email:";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(34, 114);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(104, 30);
            lbl_Password.TabIndex = 1;
            lbl_Password.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(0, 801);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1176, 35);
            textBox1.TabIndex = 2;
            // 
            // tbx_Password
            // 
            tbx_Password.Location = new Point(167, 114);
            tbx_Password.Name = "tbx_Password";
            tbx_Password.Size = new Size(549, 35);
            tbx_Password.TabIndex = 3;
            tbx_Password.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(840, 44);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(282, 100);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Location = new Point(87, 186);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(62, 30);
            lbl_Total.TabIndex = 5;
            lbl_Total.Text = "Total:";
            // 
            // lbl_NumTotal
            // 
            lbl_NumTotal.AutoSize = true;
            lbl_NumTotal.Location = new Point(187, 186);
            lbl_NumTotal.Name = "lbl_NumTotal";
            lbl_NumTotal.Size = new Size(0, 30);
            lbl_NumTotal.TabIndex = 6;
            // 
            // lbl_Recent
            // 
            lbl_Recent.AutoSize = true;
            lbl_Recent.Location = new Point(391, 186);
            lbl_Recent.Name = "lbl_Recent";
            lbl_Recent.Size = new Size(81, 30);
            lbl_Recent.TabIndex = 7;
            lbl_Recent.Text = "Recent:";
            // 
            // lbl_NumRecent
            // 
            lbl_NumRecent.AutoSize = true;
            lbl_NumRecent.Location = new Point(496, 186);
            lbl_NumRecent.Name = "lbl_NumRecent";
            lbl_NumRecent.Size = new Size(0, 30);
            lbl_NumRecent.TabIndex = 8;
            // 
            // listView
            // 
            listView.Dock = DockStyle.Bottom;
            listView.Location = new Point(0, 246);
            listView.Name = "listView";
            listView.Size = new Size(1176, 555);
            listView.TabIndex = 9;
            listView.UseCompatibleStateImageBehavior = false;
            this.listView.ItemActivate += new System.EventHandler(this.ReadMail);

            // 
            // tbx_Email
            // 
            tbx_Email.Location = new Point(167, 32);
            tbx_Email.Name = "tbx_Email";
            tbx_Email.Size = new Size(549, 35);
            tbx_Email.TabIndex = 10;
            // 
            // Lab5_BaiTap2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 836);
            Controls.Add(tbx_Email);
            Controls.Add(listView);
            Controls.Add(lbl_NumRecent);
            Controls.Add(lbl_Recent);
            Controls.Add(lbl_NumTotal);
            Controls.Add(lbl_Total);
            Controls.Add(btn_Login);
            Controls.Add(tbx_Password);
            Controls.Add(textBox1);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Email);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Lab5_BaiTap2";
            Text = "Lab5_BaiTap2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Email;
        private Label lbl_Password;
        private TextBox textBox1;
        private TextBox tbx_Password;
        private Button btn_Login;
        private Label lbl_Total;
        private Label lbl_NumTotal;
        private Label lbl_Recent;
        private Label lbl_NumRecent;
        private ListView listView;
        private TextBox tbx_Email;
    }
}