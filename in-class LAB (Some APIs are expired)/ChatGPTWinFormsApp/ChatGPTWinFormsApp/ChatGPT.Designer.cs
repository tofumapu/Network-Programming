namespace ChatGPTWinFormsApp
{
    partial class ChatGPT
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
            rtb_output = new RichTextBox();
            tbx_input = new TextBox();
            lbl_input = new Label();
            btn_send = new Button();
            SuspendLayout();
            // 
            // rtb_output
            // 
            rtb_output.Location = new Point(59, 58);
            rtb_output.Name = "rtb_output";
            rtb_output.Size = new Size(1793, 779);
            rtb_output.TabIndex = 0;
            rtb_output.Text = "";
            // 
            // tbx_input
            // 
            tbx_input.Location = new Point(59, 894);
            tbx_input.Multiline = true;
            tbx_input.Name = "tbx_input";
            tbx_input.Size = new Size(1514, 90);
            tbx_input.TabIndex = 1;
            // 
            // lbl_input
            // 
            lbl_input.AutoSize = true;
            lbl_input.Location = new Point(59, 852);
            lbl_input.Name = "lbl_input";
            lbl_input.Size = new Size(168, 30);
            lbl_input.TabIndex = 2;
            lbl_input.Text = "Message to GPT:";
            // 
            // btn_send
            // 
            btn_send.Location = new Point(1643, 892);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(209, 92);
            btn_send.TabIndex = 3;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // ChatGPT
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1896, 1016);
            Controls.Add(btn_send);
            Controls.Add(lbl_input);
            Controls.Add(tbx_input);
            Controls.Add(rtb_output);
            Name = "ChatGPT";
            Text = "ChatGPT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_output;
        private TextBox tbx_input;
        private Label lbl_input;
        private Button btn_send;
    }
}