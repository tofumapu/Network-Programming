namespace LAB3
{
    partial class LAB3_BaiTap1_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LAB3_BaiTap1_Client));
            this.ip_tb = new System.Windows.Forms.TextBox();
            this.port_tb = new System.Windows.Forms.TextBox();
            this.Send_bt = new System.Windows.Forms.Button();
            this.ip_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.message_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ip_tb
            // 
            this.ip_tb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_tb.Location = new System.Drawing.Point(132, 87);
            this.ip_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ip_tb.Name = "ip_tb";
            this.ip_tb.Size = new System.Drawing.Size(156, 32);
            this.ip_tb.TabIndex = 0;
            // 
            // port_tb
            // 
            this.port_tb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_tb.Location = new System.Drawing.Point(540, 87);
            this.port_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.port_tb.Name = "port_tb";
            this.port_tb.Size = new System.Drawing.Size(156, 32);
            this.port_tb.TabIndex = 1;
            // 
            // Send_bt
            // 
            this.Send_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_bt.Location = new System.Drawing.Point(335, 391);
            this.Send_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Send_bt.Name = "Send_bt";
            this.Send_bt.Size = new System.Drawing.Size(108, 34);
            this.Send_bt.TabIndex = 3;
            this.Send_bt.Text = "Send";
            this.Send_bt.UseVisualStyleBackColor = true;
            this.Send_bt.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ip_lb
            // 
            this.ip_lb.AutoSize = true;
            this.ip_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_lb.Location = new System.Drawing.Point(96, 94);
            this.ip_lb.Name = "ip_lb";
            this.ip_lb.Size = new System.Drawing.Size(30, 25);
            this.ip_lb.TabIndex = 5;
            this.ip_lb.Text = "IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port";
            // 
            // message_tb
            // 
            this.message_tb.Location = new System.Drawing.Point(68, 151);
            this.message_tb.Margin = new System.Windows.Forms.Padding(4);
            this.message_tb.Multiline = true;
            this.message_tb.Name = "message_tb";
            this.message_tb.Size = new System.Drawing.Size(660, 233);
            this.message_tb.TabIndex = 7;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.message_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ip_lb);
            this.Controls.Add(this.Send_bt);
            this.Controls.Add(this.port_tb);
            this.Controls.Add(this.ip_tb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}