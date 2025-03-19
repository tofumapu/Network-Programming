namespace Lab6_23520231_23520249
{
    partial class Client
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
            this.ip_tb = new System.Windows.Forms.TextBox();
            this.port_tb = new System.Windows.Forms.TextBox();
            this.Send_bt = new System.Windows.Forms.Button();
            this.ip_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.message_tb = new System.Windows.Forms.TextBox();
            this.lbl_Key = new System.Windows.Forms.Label();
            this.tbx_Key = new System.Windows.Forms.TextBox();
            this.tbx_IV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ip_tb
            // 
            this.ip_tb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_tb.Location = new System.Drawing.Point(182, 130);
            this.ip_tb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ip_tb.Name = "ip_tb";
            this.ip_tb.Size = new System.Drawing.Size(213, 42);
            this.ip_tb.TabIndex = 0;
            // 
            // port_tb
            // 
            this.port_tb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_tb.Location = new System.Drawing.Point(742, 130);
            this.port_tb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.port_tb.Name = "port_tb";
            this.port_tb.Size = new System.Drawing.Size(213, 42);
            this.port_tb.TabIndex = 1;
            // 
            // Send_bt
            // 
            this.Send_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_bt.Location = new System.Drawing.Point(461, 586);
            this.Send_bt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Send_bt.Name = "Send_bt";
            this.Send_bt.Size = new System.Drawing.Size(148, 51);
            this.Send_bt.TabIndex = 3;
            this.Send_bt.Text = "Send";
            this.Send_bt.UseVisualStyleBackColor = true;
            this.Send_bt.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ip_lb
            // 
            this.ip_lb.AutoSize = true;
            this.ip_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_lb.Location = new System.Drawing.Point(132, 141);
            this.ip_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ip_lb.Name = "ip_lb";
            this.ip_lb.Size = new System.Drawing.Size(40, 32);
            this.ip_lb.TabIndex = 5;
            this.ip_lb.Text = "IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port";
            // 
            // message_tb
            // 
            this.message_tb.Location = new System.Drawing.Point(94, 226);
            this.message_tb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.message_tb.Multiline = true;
            this.message_tb.Name = "message_tb";
            this.message_tb.Size = new System.Drawing.Size(906, 348);
            this.message_tb.TabIndex = 7;
            // 
            // lbl_Key
            // 
            this.lbl_Key.AutoSize = true;
            this.lbl_Key.Location = new System.Drawing.Point(133, 73);
            this.lbl_Key.Name = "lbl_Key";
            this.lbl_Key.Size = new System.Drawing.Size(53, 25);
            this.lbl_Key.TabIndex = 8;
            this.lbl_Key.Text = "Key:";
            // 
            // tbx_Key
            // 
            this.tbx_Key.Location = new System.Drawing.Point(192, 69);
            this.tbx_Key.Multiline = true;
            this.tbx_Key.Name = "tbx_Key";
            this.tbx_Key.Size = new System.Drawing.Size(203, 29);
            this.tbx_Key.TabIndex = 9;
            // 
            // tbx_IV
            // 
            this.tbx_IV.Location = new System.Drawing.Point(742, 70);
            this.tbx_IV.Multiline = true;
            this.tbx_IV.Name = "tbx_IV";
            this.tbx_IV.Size = new System.Drawing.Size(203, 29);
            this.tbx_IV.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "IV:";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_IV);
            this.Controls.Add(this.tbx_Key);
            this.Controls.Add(this.lbl_Key);
            this.Controls.Add(this.message_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ip_lb);
            this.Controls.Add(this.Send_bt);
            this.Controls.Add(this.port_tb);
            this.Controls.Add(this.ip_tb);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_tb;
        private System.Windows.Forms.TextBox port_tb;
        private System.Windows.Forms.Button Send_bt;
        private System.Windows.Forms.Label ip_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox message_tb;
        private System.Windows.Forms.Label lbl_Key;
        private System.Windows.Forms.TextBox tbx_Key;
        private System.Windows.Forms.TextBox tbx_IV;
        private System.Windows.Forms.Label label2;
    }
}