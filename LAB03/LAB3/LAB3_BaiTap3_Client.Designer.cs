namespace LAB3
{
    partial class LAB3_BaiTap3_Client
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
            btn_Send = new Button();
            btn_exit = new Button();
            btn_Connect = new Button();
            rtb_Output = new RichTextBox();
            rtb_Input = new RichTextBox();
            tb_Port = new TextBox();
            tb_ip = new TextBox();
            SuspendLayout();
            // 
            // btn_Send
            // 
            btn_Send.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Send.Location = new Point(594, 407);
            btn_Send.Margin = new Padding(4, 6, 4, 6);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(133, 60);
            btn_Send.TabIndex = 0;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.Location = new Point(594, 15);
            btn_exit.Margin = new Padding(4, 6, 4, 6);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(133, 56);
            btn_exit.TabIndex = 1;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_Connect
            // 
            btn_Connect.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Connect.Location = new Point(594, 314);
            btn_Connect.Margin = new Padding(4, 6, 4, 6);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(133, 66);
            btn_Connect.TabIndex = 2;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // rtb_Output
            // 
            rtb_Output.Location = new Point(36, 68);
            rtb_Output.Name = "rtb_Output";
            rtb_Output.Size = new Size(539, 281);
            rtb_Output.TabIndex = 3;
            rtb_Output.Text = "";
            // 
            // rtb_Input
            // 
            rtb_Input.Location = new Point(36, 386);
            rtb_Input.Name = "rtb_Input";
            rtb_Input.Size = new Size(539, 84);
            rtb_Input.TabIndex = 4;
            rtb_Input.Text = "";
            // 
            // tb_Port
            // 
            tb_Port.Location = new Point(278, 15);
            tb_Port.Name = "tb_Port";
            tb_Port.Size = new Size(212, 35);
            tb_Port.TabIndex = 6;
            // 
            // tb_ip
            // 
            tb_ip.Location = new Point(36, 15);
            tb_ip.Name = "tb_ip";
            tb_ip.Size = new Size(212, 35);
            tb_ip.TabIndex = 5;
            // 
            // LAB3_BaiTap3_Client
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 482);
            Controls.Add(tb_Port);
            Controls.Add(tb_ip);
            Controls.Add(rtb_Input);
            Controls.Add(rtb_Output);
            Controls.Add(btn_Connect);
            Controls.Add(btn_exit);
            Controls.Add(btn_Send);
            Margin = new Padding(4, 6, 4, 6);
            Name = "LAB3_BaiTap3_Client";
            Text = "Bai3_Client";
            FormClosed += Bai3_Client_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_Connect;
        private RichTextBox rtb_Output;
        private RichTextBox rtb_Input;
        private TextBox tb_Port;
        private TextBox tb_ip;
    }
}