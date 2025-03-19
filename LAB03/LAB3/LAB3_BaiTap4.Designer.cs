namespace LAB3
{
    partial class LAB3_BaiTap4
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
            buttonClient = new Button();
            buttonSever = new Button();
            lbl_Title = new Label();
            SuspendLayout();
            // 
            // buttonClient
            // 
            buttonClient.Location = new Point(55, 222);
            buttonClient.Margin = new Padding(6, 7, 6, 7);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(248, 114);
            buttonClient.TabIndex = 0;
            buttonClient.Text = "Client";
            buttonClient.UseVisualStyleBackColor = true;
            buttonClient.Click += buttonClient_Click;
            // 
            // buttonSever
            // 
            buttonSever.Location = new Point(484, 222);
            buttonSever.Margin = new Padding(6, 7, 6, 7);
            buttonSever.Name = "buttonSever";
            buttonSever.Size = new Size(243, 114);
            buttonSever.TabIndex = 1;
            buttonSever.Text = "Sever";
            buttonSever.UseVisualStyleBackColor = true;
            buttonSever.Click += buttonSever_Click;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(180, 109);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(427, 57);
            lbl_Title.TabIndex = 2;
            lbl_Title.Text = "Chat Room (1S - nC)";
            // 
            // LAB3_BaiTap4
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 437);
            Controls.Add(lbl_Title);
            Controls.Add(buttonSever);
            Controls.Add(buttonClient);
            Margin = new Padding(6, 7, 6, 7);
            Name = "LAB3_BaiTap4";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonSever;
        private Label lbl_Title;
    }
}