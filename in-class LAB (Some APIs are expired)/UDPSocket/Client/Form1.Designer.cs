namespace Client
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.IP_tb = new System.Windows.Forms.TextBox();
            this.Port_tb = new System.Windows.Forms.TextBox();
            this.Send_bt = new System.Windows.Forms.Button();
            this.ip_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IP_tb
            // 
            this.IP_tb.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_tb.Location = new System.Drawing.Point(129, 123);
            this.IP_tb.Margin = new System.Windows.Forms.Padding(4);
            this.IP_tb.Name = "IP_tb";
            this.IP_tb.Size = new System.Drawing.Size(213, 47);
            this.IP_tb.TabIndex = 0;
            // 
            // Port_tb
            // 
            this.Port_tb.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port_tb.Location = new System.Drawing.Point(686, 123);
            this.Port_tb.Margin = new System.Windows.Forms.Padding(4);
            this.Port_tb.Name = "Port_tb";
            this.Port_tb.Size = new System.Drawing.Size(213, 47);
            this.Port_tb.TabIndex = 1;
            // 
            // Send_bt
            // 
            this.Send_bt.Location = new System.Drawing.Point(441, 570);
            this.Send_bt.Margin = new System.Windows.Forms.Padding(4);
            this.Send_bt.Name = "Send_bt";
            this.Send_bt.Size = new System.Drawing.Size(103, 34);
            this.Send_bt.TabIndex = 3;
            this.Send_bt.Text = "Send";
            this.Send_bt.UseVisualStyleBackColor = true;
            // 
            // ip_lb
            // 
            this.ip_lb.AutoSize = true;
            this.ip_lb.Location = new System.Drawing.Point(60, 141);
            this.ip_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ip_lb.Name = "ip_lb";
            this.ip_lb.Size = new System.Drawing.Size(30, 25);
            this.ip_lb.TabIndex = 5;
            this.ip_lb.Text = "IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port";
            // 
            // data_tb
            // 
            this.data_tb.Location = new System.Drawing.Point(82, 252);
            this.data_tb.Multiline = true;
            this.data_tb.Name = "data_tb";
            this.data_tb.Size = new System.Drawing.Size(882, 282);
            this.data_tb.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.data_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ip_lb);
            this.Controls.Add(this.Send_bt);
            this.Controls.Add(this.Port_tb);
            this.Controls.Add(this.IP_tb);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.TextBox IP_tb;
        private System.Windows.Forms.TextBox Port_tb;
        private System.Windows.Forms.Button Send_bt;
        private System.Windows.Forms.Label ip_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox data_tb;
    }
}

