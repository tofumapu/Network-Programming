namespace Lab5_23520231_23520249
{
    partial class Lab5_BaiTap1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab5_BaiTap1));
            btn_Send = new Button();
            lbl_From = new Label();
            lbl_To = new Label();
            tbx_EmailFrom = new TextBox();
            tbx_EmailTo = new TextBox();
            lbl_Password = new Label();
            tbx_InputPassword = new TextBox();
            lbl_Subject = new Label();
            lbl_Body = new Label();
            rtbx_Subject = new RichTextBox();
            rtbx_Body = new RichTextBox();
            SuspendLayout();
            // 
            // btn_Send
            // 
            btn_Send.Location = new Point(49, 56);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(172, 89);
            btn_Send.TabIndex = 0;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // lbl_From
            // 
            lbl_From.AutoSize = true;
            lbl_From.Location = new Point(260, 30);
            lbl_From.Name = "lbl_From";
            lbl_From.Size = new Size(65, 30);
            lbl_From.TabIndex = 1;
            lbl_From.Text = "From:";
            // 
            // lbl_To
            // 
            lbl_To.AutoSize = true;
            lbl_To.Location = new Point(260, 110);
            lbl_To.Name = "lbl_To";
            lbl_To.Size = new Size(39, 30);
            lbl_To.TabIndex = 2;
            lbl_To.Text = "To:";
            // 
            // tbx_EmailFrom
            // 
            tbx_EmailFrom.Location = new Point(331, 27);
            tbx_EmailFrom.Name = "tbx_EmailFrom";
            tbx_EmailFrom.Size = new Size(390, 35);
            tbx_EmailFrom.TabIndex = 3;
            // 
            // tbx_EmailTo
            // 
            tbx_EmailTo.Location = new Point(331, 107);
            tbx_EmailTo.Name = "tbx_EmailTo";
            tbx_EmailTo.Size = new Size(390, 35);
            tbx_EmailTo.TabIndex = 4;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(761, 69);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(104, 30);
            lbl_Password.TabIndex = 5;
            lbl_Password.Text = "Password:";
            // 
            // tbx_InputPassword
            // 
            tbx_InputPassword.Location = new Point(871, 72);
            tbx_InputPassword.Name = "tbx_InputPassword";
            tbx_InputPassword.Size = new Size(253, 35);
            tbx_InputPassword.TabIndex = 6;
            tbx_InputPassword.UseSystemPasswordChar = true;
            // 
            // lbl_Subject
            // 
            lbl_Subject.AutoSize = true;
            lbl_Subject.Location = new Point(81, 216);
            lbl_Subject.Name = "lbl_Subject";
            lbl_Subject.Size = new Size(86, 30);
            lbl_Subject.TabIndex = 7;
            lbl_Subject.Text = "Subject:";
            // 
            // lbl_Body
            // 
            lbl_Body.AutoSize = true;
            lbl_Body.Location = new Point(81, 378);
            lbl_Body.Name = "lbl_Body";
            lbl_Body.Size = new Size(64, 30);
            lbl_Body.TabIndex = 8;
            lbl_Body.Text = "Body:";
            // 
            // rtbx_Subject
            // 
            rtbx_Subject.Location = new Point(193, 216);
            rtbx_Subject.Name = "rtbx_Subject";
            rtbx_Subject.Size = new Size(931, 95);
            rtbx_Subject.TabIndex = 9;
            rtbx_Subject.Text = "";
            // 
            // rtbx_Body
            // 
            rtbx_Body.Location = new Point(193, 378);
            rtbx_Body.Name = "rtbx_Body";
            rtbx_Body.Size = new Size(931, 338);
            rtbx_Body.TabIndex = 10;
            rtbx_Body.Text = "";
            // 
            // Lab5_BaiTap1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 836);
            Controls.Add(rtbx_Body);
            Controls.Add(rtbx_Subject);
            Controls.Add(lbl_Body);
            Controls.Add(lbl_Subject);
            Controls.Add(tbx_InputPassword);
            Controls.Add(lbl_Password);
            Controls.Add(tbx_EmailTo);
            Controls.Add(tbx_EmailFrom);
            Controls.Add(lbl_To);
            Controls.Add(lbl_From);
            Controls.Add(btn_Send);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Lab5_BaiTap1";
            Text = "Lab5_BaiTap1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Send;
        private Label lbl_From;
        private Label lbl_To;
        private TextBox tbx_EmailFrom;
        private TextBox tbx_EmailTo;
        private Label lbl_Password;
        private TextBox tbx_InputPassword;
        private Label lbl_Subject;
        private Label lbl_Body;
        private RichTextBox rtbx_Subject;
        private RichTextBox rtbx_Body;
    }
}