namespace LAB3
{
    partial class LAB3_BaiTap4_Client
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
            listBoxMessages = new ListBox();
            buttonSend = new Button();
            nameTb = new TextBox();
            lbl_Name = new Label();
            lbl_message = new Label();
            textBoxMessage = new TextBox();
            SuspendLayout();
            // 
            // listBoxMessages
            // 
            listBoxMessages.FormattingEnabled = true;
            listBoxMessages.ItemHeight = 30;
            listBoxMessages.Location = new Point(22, 37);
            listBoxMessages.Margin = new Padding(6, 7, 6, 7);
            listBoxMessages.Name = "listBoxMessages";
            listBoxMessages.Size = new Size(979, 274);
            listBoxMessages.TabIndex = 0;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(851, 512);
            buttonSend.Margin = new Padding(6, 7, 6, 7);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(150, 53);
            buttonSend.TabIndex = 1;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // nameTb
            // 
            nameTb.Location = new Point(22, 383);
            nameTb.Margin = new Padding(6, 7, 6, 7);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(366, 35);
            nameTb.TabIndex = 2;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(15, 346);
            lbl_Name.Margin = new Padding(6, 0, 6, 0);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(117, 30);
            lbl_Name.TabIndex = 3;
            lbl_Name.Text = "Your name:";
            // 
            // lbl_message
            // 
            lbl_message.AutoSize = true;
            lbl_message.Location = new Point(22, 452);
            lbl_message.Margin = new Padding(6, 0, 6, 0);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(100, 30);
            lbl_message.TabIndex = 4;
            lbl_message.Text = "Message:";
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(22, 489);
            textBoxMessage.Margin = new Padding(6, 7, 6, 7);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(685, 76);
            textBoxMessage.TabIndex = 5;
            // 
            // LAB3_BaiTap4_Client
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 636);
            Controls.Add(textBoxMessage);
            Controls.Add(lbl_message);
            Controls.Add(lbl_Name);
            Controls.Add(nameTb);
            Controls.Add(buttonSend);
            Controls.Add(listBoxMessages);
            Margin = new Padding(6, 7, 6, 7);
            Name = "LAB3_BaiTap4_Client";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.TextBox textBoxMessage;
    }
}