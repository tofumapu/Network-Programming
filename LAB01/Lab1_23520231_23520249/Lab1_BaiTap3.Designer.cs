namespace Lab1_23520231_23520249
{
    partial class Lab1_BaiTap3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1_BaiTap3));
            lbl_Title = new Label();
            lbl_Input = new Label();
            lbl_Output = new Label();
            btn_Result = new Button();
            btn_Del = new Button();
            btn_Exit = new Button();
            tb_Input = new TextBox();
            tb_Output = new TextBox();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(101, 46);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(601, 68);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "Đọc số (Dưới 19 chữ số)";
            // 
            // lbl_Input
            // 
            lbl_Input.AutoSize = true;
            lbl_Input.Location = new Point(143, 153);
            lbl_Input.Name = "lbl_Input";
            lbl_Input.Size = new Size(91, 30);
            lbl_Input.TabIndex = 1;
            lbl_Input.Text = "Nhập số";
            // 
            // lbl_Output
            // 
            lbl_Output.AutoSize = true;
            lbl_Output.Location = new Point(143, 219);
            lbl_Output.Name = "lbl_Output";
            lbl_Output.Size = new Size(84, 30);
            lbl_Output.TabIndex = 2;
            lbl_Output.Text = "Kết quả";
            // 
            // btn_Result
            // 
            btn_Result.Location = new Point(120, 374);
            btn_Result.Name = "btn_Result";
            btn_Result.Size = new Size(131, 40);
            btn_Result.TabIndex = 3;
            btn_Result.Text = "Đọc";
            btn_Result.UseVisualStyleBackColor = true;
            btn_Result.Click += btn_Result_Click_1;
            // 
            // btn_Del
            // 
            btn_Del.Location = new Point(334, 374);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(131, 40);
            btn_Del.TabIndex = 4;
            btn_Del.Text = "Xoá";
            btn_Del.UseVisualStyleBackColor = true;
            btn_Del.Click += btn_Del_Click_1;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(542, 374);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(131, 40);
            btn_Exit.TabIndex = 5;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click_1;
            // 
            // tb_Input
            // 
            tb_Input.Location = new Point(244, 153);
            tb_Input.Name = "tb_Input";
            tb_Input.Size = new Size(367, 35);
            tb_Input.TabIndex = 6;
            // 
            // tb_Output
            // 
            tb_Output.Location = new Point(244, 216);
            tb_Output.Multiline = true;
            tb_Output.Name = "tb_Output";
            tb_Output.ReadOnly = true;
            tb_Output.Size = new Size(367, 115);
            tb_Output.TabIndex = 7;
            // 
            // Lab1_BaiTap3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_Output);
            Controls.Add(tb_Input);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Del);
            Controls.Add(btn_Result);
            Controls.Add(lbl_Output);
            Controls.Add(lbl_Input);
            Controls.Add(lbl_Title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Lab1_BaiTap3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LAB1_BaiTap3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Title;
        private Label lbl_Input;
        private Label lbl_Output;
        private Button btn_Result;
        private Button btn_Del;
        private Button btn_Exit;
        private TextBox tb_Input;
        private TextBox tb_Output;
    }
}