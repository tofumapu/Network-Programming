namespace LAB3
{
    partial class LAB3_BaiTap2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Listen = new Button();
            rtb_Output = new RichTextBox();
            SuspendLayout();
            // 
            // btn_Listen
            // 
            btn_Listen.Location = new Point(699, 28);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(131, 40);
            btn_Listen.TabIndex = 0;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // rtb_Output
            // 
            rtb_Output.Location = new Point(42, 90);
            rtb_Output.Name = "rtb_Output";
            rtb_Output.Size = new Size(788, 396);
            rtb_Output.TabIndex = 1;
            rtb_Output.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 527);
            Controls.Add(rtb_Output);
            Controls.Add(btn_Listen);
            Name = "Form1";
            Text = "Lab3_BaiTap2";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Listen;
        private RichTextBox rtb_Output;
    }
}
