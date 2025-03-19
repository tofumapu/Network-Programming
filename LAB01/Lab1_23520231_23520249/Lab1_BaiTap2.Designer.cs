namespace Lab1_23520231_23520249
{
    partial class Lab1_BaiTap2 : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1_BaiTap2));
            lbl_Title = new Label();
            gp_Input = new GroupBox();
            tb_num3 = new TextBox();
            lbl_num3 = new Label();
            tb_num2 = new TextBox();
            lbl_num2 = new Label();
            tb_num1 = new TextBox();
            lbl_num1 = new Label();
            gp_Result = new GroupBox();
            tb_max = new TextBox();
            lbl_max = new Label();
            tb_min = new TextBox();
            lbl_min = new Label();
            btn_Result = new Button();
            btn_Del = new Button();
            btn_Exit = new Button();
            gp_Input.SuspendLayout();
            gp_Result.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.OrangeRed;
            lbl_Title.Location = new Point(94, 34);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(866, 63);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "TÌM SỐ NHỎ NHẤT, LỚN NHẤT";
            // 
            // gp_Input
            // 
            gp_Input.BackColor = SystemColors.ControlLight;
            gp_Input.Controls.Add(tb_num3);
            gp_Input.Controls.Add(lbl_num3);
            gp_Input.Controls.Add(tb_num2);
            gp_Input.Controls.Add(lbl_num2);
            gp_Input.Controls.Add(tb_num1);
            gp_Input.Controls.Add(lbl_num1);
            gp_Input.Location = new Point(74, 122);
            gp_Input.Name = "gp_Input";
            gp_Input.Size = new Size(903, 151);
            gp_Input.TabIndex = 2;
            gp_Input.TabStop = false;
            gp_Input.Text = "Các giá trị";
            // 
            // tb_num3
            // 
            tb_num3.Location = new Point(711, 57);
            tb_num3.Name = "tb_num3";
            tb_num3.Size = new Size(175, 35);
            tb_num3.TabIndex = 5;
            // 
            // lbl_num3
            // 
            lbl_num3.AutoSize = true;
            lbl_num3.Location = new Point(615, 62);
            lbl_num3.Name = "lbl_num3";
            lbl_num3.Size = new Size(90, 30);
            lbl_num3.TabIndex = 4;
            lbl_num3.Text = "Số thứ 3";
            // 
            // tb_num2
            // 
            tb_num2.Location = new Point(414, 57);
            tb_num2.Name = "tb_num2";
            tb_num2.Size = new Size(175, 35);
            tb_num2.TabIndex = 3;
            // 
            // lbl_num2
            // 
            lbl_num2.AutoSize = true;
            lbl_num2.Location = new Point(318, 62);
            lbl_num2.Name = "lbl_num2";
            lbl_num2.Size = new Size(90, 30);
            lbl_num2.TabIndex = 2;
            lbl_num2.Text = "Số thứ 2";
            // 
            // tb_num1
            // 
            tb_num1.Location = new Point(116, 59);
            tb_num1.Name = "tb_num1";
            tb_num1.Size = new Size(175, 35);
            tb_num1.TabIndex = 1;
            // 
            // lbl_num1
            // 
            lbl_num1.AutoSize = true;
            lbl_num1.Location = new Point(20, 62);
            lbl_num1.Name = "lbl_num1";
            lbl_num1.Size = new Size(90, 30);
            lbl_num1.TabIndex = 0;
            lbl_num1.Text = "Số thứ 1";
            // 
            // gp_Result
            // 
            gp_Result.Controls.Add(tb_max);
            gp_Result.Controls.Add(lbl_max);
            gp_Result.Controls.Add(tb_min);
            gp_Result.Controls.Add(lbl_min);
            gp_Result.Location = new Point(74, 407);
            gp_Result.Name = "gp_Result";
            gp_Result.Size = new Size(903, 159);
            gp_Result.TabIndex = 3;
            gp_Result.TabStop = false;
            gp_Result.Text = "Kết quả";
            // 
            // tb_max
            // 
            tb_max.Location = new Point(643, 71);
            tb_max.Name = "tb_max";
            tb_max.Size = new Size(175, 35);
            tb_max.TabIndex = 3;
            // 
            // lbl_max
            // 
            lbl_max.AutoSize = true;
            lbl_max.Location = new Point(517, 71);
            lbl_max.Name = "lbl_max";
            lbl_max.Size = new Size(120, 30);
            lbl_max.TabIndex = 2;
            lbl_max.Text = "Số lớn nhất";
            // 
            // tb_min
            // 
            tb_min.Location = new Point(178, 71);
            tb_min.Name = "tb_min";
            tb_min.Size = new Size(175, 35);
            tb_min.TabIndex = 1;
            // 
            // lbl_min
            // 
            lbl_min.AutoSize = true;
            lbl_min.Location = new Point(59, 71);
            lbl_min.Name = "lbl_min";
            lbl_min.Size = new Size(113, 30);
            lbl_min.TabIndex = 0;
            lbl_min.Text = "Số bé nhất";
            // 
            // btn_Result
            // 
            btn_Result.Location = new Point(236, 334);
            btn_Result.Name = "btn_Result";
            btn_Result.Size = new Size(131, 40);
            btn_Result.TabIndex = 4;
            btn_Result.Text = "Tìm";
            btn_Result.UseVisualStyleBackColor = true;
            btn_Result.Click += btn_Result_Click;
            // 
            // btn_Del
            // 
            btn_Del.Location = new Point(464, 334);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(131, 40);
            btn_Del.TabIndex = 5;
            btn_Del.Text = "Xoá";
            btn_Del.UseVisualStyleBackColor = true;
            btn_Del.Click += btn_Del_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(689, 334);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(131, 40);
            btn_Exit.TabIndex = 6;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Lab1_BaiTap2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 656);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Del);
            Controls.Add(btn_Result);
            Controls.Add(gp_Result);
            Controls.Add(gp_Input);
            Controls.Add(lbl_Title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Lab1_BaiTap2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LAB1_BaiTap2";
            Load += LAB1_BaiTap2_Load;
            gp_Input.ResumeLayout(false);
            gp_Input.PerformLayout();
            gp_Result.ResumeLayout(false);
            gp_Result.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title;
        private GroupBox gp_Input;
        private GroupBox gp_Result;
        private Button btn_Result;
        private Button btn_Del;
        private Button btn_Exit;
        private TextBox tb_num3;
        private Label lbl_num3;
        private TextBox tb_num2;
        private Label lbl_num2;
        private TextBox tb_num1;
        private Label lbl_num1;
        private TextBox tb_max;
        private Label lbl_max;
        private TextBox tb_min;
        private Label lbl_min;
    }
}