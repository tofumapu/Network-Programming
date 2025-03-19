namespace Lab6_23520231_23520249
{
    partial class Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.port_tb = new System.Windows.Forms.TextBox();
            this.message_lbx = new System.Windows.Forms.ListBox();
            this.listen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_Key = new System.Windows.Forms.TextBox();
            this.tbx_IV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // port_tb
            // 
            this.port_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_tb.Location = new System.Drawing.Point(300, 124);
            this.port_tb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.port_tb.Name = "port_tb";
            this.port_tb.Size = new System.Drawing.Size(322, 39);
            this.port_tb.TabIndex = 1;
            // 
            // message_lbx
            // 
            this.message_lbx.FormattingEnabled = true;
            this.message_lbx.ItemHeight = 24;
            this.message_lbx.Location = new System.Drawing.Point(138, 240);
            this.message_lbx.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.message_lbx.Name = "message_lbx";
            this.message_lbx.Size = new System.Drawing.Size(1132, 508);
            this.message_lbx.TabIndex = 2;
            // 
            // listen
            // 
            this.listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listen.Location = new System.Drawing.Point(971, 117);
            this.listen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(212, 62);
            this.listen.TabIndex = 3;
            this.listen.Text = "Listen";
            this.listen.UseVisualStyleBackColor = true;
            this.listen.Click += new System.EventHandler(this.listen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(949, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "IV:";
            // 
            // tbx_Key
            // 
            this.tbx_Key.Location = new System.Drawing.Point(300, 58);
            this.tbx_Key.Multiline = true;
            this.tbx_Key.Name = "tbx_Key";
            this.tbx_Key.Size = new System.Drawing.Size(322, 37);
            this.tbx_Key.TabIndex = 6;
            // 
            // tbx_IV
            // 
            this.tbx_IV.Location = new System.Drawing.Point(992, 58);
            this.tbx_IV.Multiline = true;
            this.tbx_IV.Name = "tbx_IV";
            this.tbx_IV.Size = new System.Drawing.Size(322, 37);
            this.tbx_IV.TabIndex = 7;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.tbx_IV);
            this.Controls.Add(this.tbx_Key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listen);
            this.Controls.Add(this.message_lbx);
            this.Controls.Add(this.port_tb);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox port_tb;
        private System.Windows.Forms.ListBox message_lbx;
        private System.Windows.Forms.Button listen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_Key;
        private System.Windows.Forms.TextBox tbx_IV;
    }
}