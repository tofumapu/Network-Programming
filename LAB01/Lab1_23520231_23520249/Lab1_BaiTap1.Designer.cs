namespace Lab1_23520231_23520249
{
    partial class Lab1_BaiTap1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1_BaiTap1));
            tb_Title = new TextBox();
            lbl_Result = new Label();
            lbl_SecondNum = new Label();
            lbl_FirstNum = new Label();
            tb_Result = new TextBox();
            tb_SecondNum = new TextBox();
            tb_FirstNum = new TextBox();
            btn_Product = new Button();
            btn_Del = new Button();
            btn_Divide = new Button();
            btn_Add = new Button();
            btn_Minus = new Button();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // tb_Title
            // 
            tb_Title.BackColor = SystemColors.Control;
            tb_Title.BorderStyle = BorderStyle.None;
            tb_Title.Enabled = false;
            tb_Title.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            tb_Title.Location = new Point(18, 22);
            tb_Title.Margin = new Padding(4, 6, 4, 6);
            tb_Title.Name = "tb_Title";
            tb_Title.ReadOnly = true;
            tb_Title.Size = new Size(1164, 65);
            tb_Title.TabIndex = 0;
            tb_Title.Text = "TÍNH TOÁN";
            tb_Title.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_Result
            // 
            lbl_Result.AutoSize = true;
            lbl_Result.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbl_Result.Location = new Point(186, 467);
            lbl_Result.Margin = new Padding(4, 0, 4, 0);
            lbl_Result.Name = "lbl_Result";
            lbl_Result.Size = new Size(149, 44);
            lbl_Result.TabIndex = 1;
            lbl_Result.Text = "Kết quả";
            // 
            // lbl_SecondNum
            // 
            lbl_SecondNum.AutoSize = true;
            lbl_SecondNum.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbl_SecondNum.Location = new Point(176, 324);
            lbl_SecondNum.Margin = new Padding(4, 0, 4, 0);
            lbl_SecondNum.Name = "lbl_SecondNum";
            lbl_SecondNum.Size = new Size(159, 44);
            lbl_SecondNum.TabIndex = 2;
            lbl_SecondNum.Text = "Số thứ 2";
            // 
            // lbl_FirstNum
            // 
            lbl_FirstNum.AutoSize = true;
            lbl_FirstNum.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbl_FirstNum.Location = new Point(176, 184);
            lbl_FirstNum.Margin = new Padding(4, 0, 4, 0);
            lbl_FirstNum.Name = "lbl_FirstNum";
            lbl_FirstNum.Size = new Size(159, 44);
            lbl_FirstNum.TabIndex = 3;
            lbl_FirstNum.Text = "Số thứ 1";
            // 
            // tb_Result
            // 
            tb_Result.BackColor = SystemColors.ControlLightLight;
            tb_Result.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            tb_Result.ForeColor = SystemColors.WindowFrame;
            tb_Result.Location = new Point(434, 456);
            tb_Result.Margin = new Padding(4, 6, 4, 6);
            tb_Result.Name = "tb_Result";
            tb_Result.ReadOnly = true;
            tb_Result.Size = new Size(334, 50);
            tb_Result.TabIndex = 4;
            // 
            // tb_SecondNum
            // 
            tb_SecondNum.BackColor = SystemColors.ControlLightLight;
            tb_SecondNum.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            tb_SecondNum.ForeColor = SystemColors.WindowFrame;
            tb_SecondNum.Location = new Point(434, 313);
            tb_SecondNum.Margin = new Padding(4, 6, 4, 6);
            tb_SecondNum.Name = "tb_SecondNum";
            tb_SecondNum.Size = new Size(334, 50);
            tb_SecondNum.TabIndex = 5;
            // 
            // tb_FirstNum
            // 
            tb_FirstNum.BackColor = SystemColors.ControlLightLight;
            tb_FirstNum.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            tb_FirstNum.ForeColor = SystemColors.WindowFrame;
            tb_FirstNum.Location = new Point(434, 172);
            tb_FirstNum.Margin = new Padding(4, 6, 4, 6);
            tb_FirstNum.Name = "tb_FirstNum";
            tb_FirstNum.Size = new Size(334, 50);
            tb_FirstNum.TabIndex = 6;
            // 
            // btn_Product
            // 
            btn_Product.FlatStyle = FlatStyle.Popup;
            btn_Product.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Product.Location = new Point(640, 570);
            btn_Product.Margin = new Padding(4, 6, 4, 6);
            btn_Product.Name = "btn_Product";
            btn_Product.Size = new Size(129, 79);
            btn_Product.TabIndex = 7;
            btn_Product.Text = "X";
            btn_Product.UseVisualStyleBackColor = true;
            btn_Product.Click += btn_Product_Click;
            // 
            // btn_Del
            // 
            btn_Del.FlatStyle = FlatStyle.Popup;
            btn_Del.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Del.Location = new Point(336, 679);
            btn_Del.Margin = new Padding(4, 6, 4, 6);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(226, 79);
            btn_Del.TabIndex = 8;
            btn_Del.Text = "Xóa";
            btn_Del.UseVisualStyleBackColor = true;
            btn_Del.Click += btn_Del_Click;
            // 
            // btn_Divide
            // 
            btn_Divide.FlatStyle = FlatStyle.Popup;
            btn_Divide.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Divide.Location = new Point(854, 570);
            btn_Divide.Margin = new Padding(4, 6, 4, 6);
            btn_Divide.Name = "btn_Divide";
            btn_Divide.Size = new Size(129, 79);
            btn_Divide.TabIndex = 9;
            btn_Divide.Text = "/";
            btn_Divide.UseVisualStyleBackColor = true;
            btn_Divide.Click += btn_Divide_Click;
            // 
            // btn_Add
            // 
            btn_Add.FlatStyle = FlatStyle.Popup;
            btn_Add.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Add.Location = new Point(225, 570);
            btn_Add.Margin = new Padding(4, 6, 4, 6);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(129, 79);
            btn_Add.TabIndex = 10;
            btn_Add.Text = "+";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Minus
            // 
            btn_Minus.FlatStyle = FlatStyle.Popup;
            btn_Minus.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Minus.Location = new Point(434, 570);
            btn_Minus.Margin = new Padding(4, 6, 4, 6);
            btn_Minus.Name = "btn_Minus";
            btn_Minus.Size = new Size(129, 79);
            btn_Minus.TabIndex = 11;
            btn_Minus.Text = "-";
            btn_Minus.UseVisualStyleBackColor = true;
            btn_Minus.Click += btn_Minus_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.FlatStyle = FlatStyle.Popup;
            btn_Exit.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Exit.Location = new Point(640, 679);
            btn_Exit.Margin = new Padding(4, 6, 4, 6);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(226, 79);
            btn_Exit.TabIndex = 12;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Lab1_BaiTap1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 844);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Minus);
            Controls.Add(btn_Add);
            Controls.Add(btn_Divide);
            Controls.Add(btn_Del);
            Controls.Add(btn_Product);
            Controls.Add(tb_FirstNum);
            Controls.Add(tb_SecondNum);
            Controls.Add(tb_Result);
            Controls.Add(lbl_FirstNum);
            Controls.Add(lbl_SecondNum);
            Controls.Add(lbl_Result);
            Controls.Add(tb_Title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            Name = "Lab1_BaiTap1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab1_BaiTap1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Label lbl_SecondNum;
        private System.Windows.Forms.Label lbl_FirstNum;
        private System.Windows.Forms.TextBox tb_Result;
        private System.Windows.Forms.TextBox tb_SecondNum;
        private System.Windows.Forms.TextBox tb_FirstNum;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Divide;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Exit;

    }
}