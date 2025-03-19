using System.Diagnostics.Metrics;

namespace LAB3
{
    partial class LAB3_BaiTap1_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LAB3_BaiTap1_Server));
            this.label1 = new System.Windows.Forms.Label();
            this.port_tb = new System.Windows.Forms.TextBox();
            this.message_lbx = new System.Windows.Forms.ListBox();
            this.listen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // port_tb
            // 
            this.port_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_tb.Location = new System.Drawing.Point(218, 83);
            this.port_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.port_tb.Name = "port_tb";
            this.port_tb.Size = new System.Drawing.Size(235, 30);
            this.port_tb.TabIndex = 1;
            // 
            // message_lbx
            // 
            this.message_lbx.FormattingEnabled = true;
            this.message_lbx.ItemHeight = 16;
            this.message_lbx.Location = new System.Drawing.Point(100, 160);
            this.message_lbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.message_lbx.Name = "message_lbx";
            this.message_lbx.Size = new System.Drawing.Size(824, 340);
            this.message_lbx.TabIndex = 2;
            // 
            // listen
            // 
            this.listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listen.Location = new System.Drawing.Point(706, 78);
            this.listen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(154, 41);
            this.listen.TabIndex = 3;
            this.listen.Text = "Listen";
            this.listen.UseVisualStyleBackColor = true;
            this.listen.Click += new System.EventHandler(this.listen_Click);
            // 
            // Sever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listen);
            this.Controls.Add(this.message_lbx);
            this.Controls.Add(this.port_tb);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sever";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox port_tb;
        private System.Windows.Forms.ListBox message_lbx;
        private System.Windows.Forms.Button listen;
    }
}
