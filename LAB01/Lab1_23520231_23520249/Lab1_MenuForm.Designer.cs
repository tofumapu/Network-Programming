namespace Lab1_23520231_23520249
{
    partial class Lab1_MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1_MenuForm));
            lbl_Title = new Label();
            btn_Exit = new Button();
            btn_BaiTap1 = new Button();
            btn_BaiTap2 = new Button();
            btn_BaiTap3 = new Button();
            btn_BaiTap4 = new Button();
            btn_BaiTap5 = new Button();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.IndianRed;
            lbl_Title.Location = new Point(197, 36);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(392, 68);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "MENU BÀI TẬP";
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(470, 327);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(182, 66);
            btn_Exit.TabIndex = 6;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_BaiTap1
            // 
            btn_BaiTap1.Location = new Point(133, 126);
            btn_BaiTap1.Name = "btn_BaiTap1";
            btn_BaiTap1.Size = new Size(182, 66);
            btn_BaiTap1.TabIndex = 1;
            btn_BaiTap1.Text = "Bài tập 1";
            btn_BaiTap1.UseVisualStyleBackColor = true;
            btn_BaiTap1.Click += btn_BaiTap1_Click;
            // 
            // btn_BaiTap2
            // 
            btn_BaiTap2.Location = new Point(470, 127);
            btn_BaiTap2.Name = "btn_BaiTap2";
            btn_BaiTap2.Size = new Size(182, 66);
            btn_BaiTap2.TabIndex = 2;
            btn_BaiTap2.Text = "Bài tập 2";
            btn_BaiTap2.UseVisualStyleBackColor = true;
            btn_BaiTap2.Click += btn_BaiTap2_Click;
            // 
            // btn_BaiTap3
            // 
            btn_BaiTap3.Location = new Point(133, 221);
            btn_BaiTap3.Name = "btn_BaiTap3";
            btn_BaiTap3.Size = new Size(182, 66);
            btn_BaiTap3.TabIndex = 3;
            btn_BaiTap3.Text = "Bài tập 3";
            btn_BaiTap3.UseVisualStyleBackColor = true;
            btn_BaiTap3.Click += btn_BaiTap3_Click;
            // 
            // btn_BaiTap4
            // 
            btn_BaiTap4.Location = new Point(470, 221);
            btn_BaiTap4.Name = "btn_BaiTap4";
            btn_BaiTap4.Size = new Size(182, 66);
            btn_BaiTap4.TabIndex = 4;
            btn_BaiTap4.Text = "Bài tập 4";
            btn_BaiTap4.UseVisualStyleBackColor = true;
            btn_BaiTap4.Click += btn_BaiTap4_Click;
            // 
            // btn_BaiTap5
            // 
            btn_BaiTap5.Location = new Point(133, 327);
            btn_BaiTap5.Name = "btn_BaiTap5";
            btn_BaiTap5.Size = new Size(182, 66);
            btn_BaiTap5.TabIndex = 5;
            btn_BaiTap5.Text = "Bài tập 5";
            btn_BaiTap5.UseVisualStyleBackColor = true;
            btn_BaiTap5.Click += btn_BaiTap5_Click;
            // 
            // Lab1_MenuForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Exit);
            Controls.Add(btn_BaiTap5);
            Controls.Add(btn_BaiTap4);
            Controls.Add(btn_BaiTap3);
            Controls.Add(btn_BaiTap2);
            Controls.Add(btn_BaiTap1);
            Controls.Add(lbl_Title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Lab1_MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab1_MenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title;
        private Button btn_Exit;
        private Button btn_BaiTap1;
        private Button btn_BaiTap2;
        private Button btn_BaiTap3;
        private Button btn_BaiTap4;
        private Button btn_BaiTap5;
    }
}