namespace MultiFileReader
{
    partial class MultiFileReader
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
            openFileDialog1 = new OpenFileDialog();
            btn_Choose = new Button();
            rtbx_Output = new RichTextBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
            // 
            // btn_Choose
            // 
            btn_Choose.Location = new Point(861, 590);
            btn_Choose.Name = "btn_Choose";
            btn_Choose.Size = new Size(131, 40);
            btn_Choose.TabIndex = 0;
            btn_Choose.Text = "Choose";
            btn_Choose.UseVisualStyleBackColor = true;
            btn_Choose.Click += btn_Choose_Click;
            // 
            // rtbx_Output
            // 
            rtbx_Output.Location = new Point(50, 51);
            rtbx_Output.Name = "rtbx_Output";
            rtbx_Output.Size = new Size(942, 523);
            rtbx_Output.TabIndex = 1;
            rtbx_Output.Text = "";
            // 
            // MultiFileReader
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 656);
            Controls.Add(rtbx_Output);
            Controls.Add(btn_Choose);
            Name = "MultiFileReader";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MultiFileReader";
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btn_Choose;
        private RichTextBox rtbx_Output;
    }
}