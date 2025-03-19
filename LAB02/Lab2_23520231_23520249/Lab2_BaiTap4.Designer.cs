namespace Lab2_23520231_23520249
{
    partial class Lab2_BaiTap4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2_BaiTap4));
            btn_Nhap = new Button();
            btn_Luu = new Button();
            btn_HienThiThongTin = new Button();
            dataGridView_SinhVien = new DataGridView();
            btn_Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SinhVien).BeginInit();
            SuspendLayout();
            // 
            // btn_Nhap
            // 
            btn_Nhap.Location = new Point(37, 152);
            btn_Nhap.Name = "btn_Nhap";
            btn_Nhap.Size = new Size(205, 40);
            btn_Nhap.TabIndex = 0;
            btn_Nhap.Text = "Nhập dữ liệu";
            btn_Nhap.UseVisualStyleBackColor = true;
            btn_Nhap.Click += btn_Nhap_Click;
            // 
            // btn_Luu
            // 
            btn_Luu.Location = new Point(37, 274);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(205, 40);
            btn_Luu.TabIndex = 1;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = true;
            btn_Luu.Click += btn_Luu_Click;
            // 
            // btn_HienThiThongTin
            // 
            btn_HienThiThongTin.Location = new Point(37, 408);
            btn_HienThiThongTin.Name = "btn_HienThiThongTin";
            btn_HienThiThongTin.Size = new Size(205, 40);
            btn_HienThiThongTin.TabIndex = 2;
            btn_HienThiThongTin.Text = "Hiển thị thông tin";
            btn_HienThiThongTin.UseVisualStyleBackColor = true;
            btn_HienThiThongTin.Click += btn_HienThiThongTin_Click;
            // 
            // dataGridView_SinhVien
            // 
            dataGridView_SinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_SinhVien.Location = new Point(274, 44);
            dataGridView_SinhVien.Name = "dataGridView_SinhVien";
            dataGridView_SinhVien.RowHeadersWidth = 72;
            dataGridView_SinhVien.Size = new Size(1099, 878);
            dataGridView_SinhVien.TabIndex = 3;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(1242, 951);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(131, 40);
            btn_Exit.TabIndex = 4;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Lab2_BaiTap4
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 1016);
            Controls.Add(btn_Exit);
            Controls.Add(dataGridView_SinhVien);
            Controls.Add(btn_HienThiThongTin);
            Controls.Add(btn_Luu);
            Controls.Add(btn_Nhap);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Lab2_BaiTap4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab2_BaiTap4";
            ((System.ComponentModel.ISupportInitialize)dataGridView_SinhVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Nhap;
        private Button btn_Luu;
        private Button btn_HienThiThongTin;
        private DataGridView dataGridView_SinhVien;
        private Button btn_Exit;
    }
}