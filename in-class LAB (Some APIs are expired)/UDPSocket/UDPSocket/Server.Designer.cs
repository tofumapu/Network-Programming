namespace UDPSocket
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
            this.lbl_Port = new System.Windows.Forms.Label();
            this.btn_Listen = new System.Windows.Forms.Button();
            this.tbx_Output = new System.Windows.Forms.TextBox();
            this.tbx_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(62, 56);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(47, 25);
            this.lbl_Port.TabIndex = 0;
            this.lbl_Port.Text = "Port";
            // 
            // btn_Listen
            // 
            this.btn_Listen.Location = new System.Drawing.Point(501, 49);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(241, 38);
            this.btn_Listen.TabIndex = 2;
            this.btn_Listen.Text = "Listen";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // tbx_Output
            // 
            this.tbx_Output.Location = new System.Drawing.Point(67, 108);
            this.tbx_Output.Multiline = true;
            this.tbx_Output.Name = "tbx_Output";
            this.tbx_Output.Size = new System.Drawing.Size(675, 318);
            this.tbx_Output.TabIndex = 3;
            // 
            // tbx_Input
            // 
            this.tbx_Input.Location = new System.Drawing.Point(138, 52);
            this.tbx_Input.Name = "tbx_Input";
            this.tbx_Input.Size = new System.Drawing.Size(295, 29);
            this.tbx_Input.TabIndex = 4;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_Input);
            this.Controls.Add(this.tbx_Output);
            this.Controls.Add(this.btn_Listen);
            this.Controls.Add(this.lbl_Port);
            this.Name = "Server";
            this.Text = "UDP Server";
//            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.TextBox tbx_Output;
        private System.Windows.Forms.TextBox tbx_Input;
    }
}

