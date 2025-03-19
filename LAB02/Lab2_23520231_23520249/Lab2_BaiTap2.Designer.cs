namespace Lab2_23520231_23520249
{
    partial class Lab2_BaiTap2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2_BaiTap2));
            btn_ReadFile = new Button();
            rtbx_Output = new RichTextBox();
            lbl_FileName = new Label();
            lbl_URL = new Label();
            lbl_CountLine = new Label();
            lbl_CountWord = new Label();
            lbl_CountCharacter = new Label();
            tbx_FileName = new TextBox();
            tbx_URL = new TextBox();
            tbx_CountLine = new TextBox();
            tbx_CountWord = new TextBox();
            tbx_CountCharacter = new TextBox();
            openFileDialog = new OpenFileDialog();
            btn_Hide = new Button();
            SuspendLayout();
            // 
            // btn_ReadFile
            // 
            btn_ReadFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ReadFile.Location = new Point(117, 38);
            btn_ReadFile.Name = "btn_ReadFile";
            btn_ReadFile.Size = new Size(289, 130);
            btn_ReadFile.TabIndex = 0;
            btn_ReadFile.Text = "ĐỌC FILE";
            btn_ReadFile.UseVisualStyleBackColor = true;
            btn_ReadFile.Click += btn_ReadFile_Click;
            // 
            // rtbx_Output
            // 
            rtbx_Output.Location = new Point(534, 38);
            rtbx_Output.Name = "rtbx_Output";
            rtbx_Output.Size = new Size(848, 947);
            rtbx_Output.TabIndex = 1;
            rtbx_Output.Text = "";
            // 
            // lbl_FileName
            // 
            lbl_FileName.AutoSize = true;
            lbl_FileName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FileName.Location = new Point(15, 219);
            lbl_FileName.Name = "lbl_FileName";
            lbl_FileName.Size = new Size(84, 30);
            lbl_FileName.TabIndex = 2;
            lbl_FileName.Text = "Tên file";
            // 
            // lbl_URL
            // 
            lbl_URL.AutoSize = true;
            lbl_URL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_URL.Location = new Point(15, 297);
            lbl_URL.Name = "lbl_URL";
            lbl_URL.Size = new Size(53, 30);
            lbl_URL.TabIndex = 3;
            lbl_URL.Text = "URL";
            // 
            // lbl_CountLine
            // 
            lbl_CountLine.AutoSize = true;
            lbl_CountLine.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CountLine.Location = new Point(15, 439);
            lbl_CountLine.Name = "lbl_CountLine";
            lbl_CountLine.Size = new Size(96, 30);
            lbl_CountLine.TabIndex = 4;
            lbl_CountLine.Text = "Số dòng";
            // 
            // lbl_CountWord
            // 
            lbl_CountWord.AutoSize = true;
            lbl_CountWord.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CountWord.Location = new Point(15, 516);
            lbl_CountWord.Name = "lbl_CountWord";
            lbl_CountWord.Size = new Size(66, 30);
            lbl_CountWord.TabIndex = 5;
            lbl_CountWord.Text = "Số từ";
            // 
            // lbl_CountCharacter
            // 
            lbl_CountCharacter.AutoSize = true;
            lbl_CountCharacter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CountCharacter.Location = new Point(15, 598);
            lbl_CountCharacter.Name = "lbl_CountCharacter";
            lbl_CountCharacter.Size = new Size(95, 30);
            lbl_CountCharacter.TabIndex = 6;
            lbl_CountCharacter.Text = "Số ký tự";
            // 
            // tbx_FileName
            // 
            tbx_FileName.Location = new Point(117, 216);
            tbx_FileName.Name = "tbx_FileName";
            tbx_FileName.Size = new Size(397, 35);
            tbx_FileName.TabIndex = 7;
            // 
            // tbx_URL
            // 
            tbx_URL.Location = new Point(117, 297);
            tbx_URL.Multiline = true;
            tbx_URL.Name = "tbx_URL";
            tbx_URL.Size = new Size(397, 107);
            tbx_URL.TabIndex = 8;
            // 
            // tbx_CountLine
            // 
            tbx_CountLine.Location = new Point(117, 439);
            tbx_CountLine.Name = "tbx_CountLine";
            tbx_CountLine.Size = new Size(215, 35);
            tbx_CountLine.TabIndex = 9;
            // 
            // tbx_CountWord
            // 
            tbx_CountWord.Location = new Point(117, 516);
            tbx_CountWord.Name = "tbx_CountWord";
            tbx_CountWord.Size = new Size(215, 35);
            tbx_CountWord.TabIndex = 10;
            // 
            // tbx_CountCharacter
            // 
            tbx_CountCharacter.Location = new Point(117, 595);
            tbx_CountCharacter.Name = "tbx_CountCharacter";
            tbx_CountCharacter.Size = new Size(215, 35);
            tbx_CountCharacter.TabIndex = 11;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // btn_Hide
            // 
            btn_Hide.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Hide.Location = new Point(117, 679);
            btn_Hide.Name = "btn_Hide";
            btn_Hide.Size = new Size(289, 130);
            btn_Hide.TabIndex = 12;
            btn_Hide.Text = "Thoát";
            btn_Hide.UseVisualStyleBackColor = true;
            btn_Hide.Click += btn_Hide_Click;
            // 
            // Lab2_BaiTap2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 1016);
            Controls.Add(btn_Hide);
            Controls.Add(tbx_CountCharacter);
            Controls.Add(tbx_CountWord);
            Controls.Add(tbx_CountLine);
            Controls.Add(tbx_URL);
            Controls.Add(tbx_FileName);
            Controls.Add(lbl_CountCharacter);
            Controls.Add(lbl_CountWord);
            Controls.Add(lbl_CountLine);
            Controls.Add(lbl_URL);
            Controls.Add(lbl_FileName);
            Controls.Add(rtbx_Output);
            Controls.Add(btn_ReadFile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Lab2_BaiTap2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab2_BaiTap2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ReadFile;
        private RichTextBox rtbx_Output;
        private Label lbl_FileName;
        private Label lbl_URL;
        private Label lbl_CountLine;
        private Label lbl_CountWord;
        private Label lbl_CountCharacter;
        private TextBox tbx_FileName;
        private TextBox tbx_URL;
        private TextBox tbx_CountLine;
        private TextBox tbx_CountWord;
        private TextBox tbx_CountCharacter;
        private OpenFileDialog openFileDialog;
        private Button btn_Hide;
    }
}