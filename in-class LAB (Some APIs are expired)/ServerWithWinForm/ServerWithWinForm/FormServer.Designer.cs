namespace ServerWithWinForm
{
    partial class FormServer
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
            rtb_Server = new RichTextBox();
            SuspendLayout();
            // 
            // rtb_Server
            // 
            rtb_Server.Location = new Point(12, 52);
            rtb_Server.Name = "rtb_Server";
            rtb_Server.Size = new Size(1145, 756);
            rtb_Server.TabIndex = 0;
            rtb_Server.Text = "";
            // 
            // FormServer
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 836);
            Controls.Add(rtb_Server);
            Name = "FormServer";
            Text = "FormServer";
            ResumeLayout(false);
        }

        #endregion

        public RichTextBox rtb_Server;
    }
}