namespace Lab1_23520231_23520249
{
    partial class Lab1_BaiTap4 : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1_BaiTap4));
            label1 = new Label();
            groupBox1 = new GroupBox();
            bt_Xoa = new Button();
            bt_Thoat = new Button();
            bt_ThucHien = new Button();
            cb_SoChuyen = new ComboBox();
            cb_SoNhap = new ComboBox();
            tbx_Nhap = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbx_KetQua = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(51, 88);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 38);
            label1.TabIndex = 0;
            label1.Text = "Nhập một số:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(bt_Xoa);
            groupBox1.Controls.Add(bt_Thoat);
            groupBox1.Controls.Add(bt_ThucHien);
            groupBox1.Controls.Add(cb_SoChuyen);
            groupBox1.Controls.Add(cb_SoNhap);
            groupBox1.Controls.Add(tbx_Nhap);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(16, 36);
            groupBox1.Margin = new Padding(4, 6, 4, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 6, 4, 6);
            groupBox1.Size = new Size(1164, 407);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // bt_Xoa
            // 
            bt_Xoa.BackColor = SystemColors.ControlText;
            bt_Xoa.ForeColor = SystemColors.Control;
            bt_Xoa.Location = new Point(598, 291);
            bt_Xoa.Margin = new Padding(4, 6, 4, 6);
            bt_Xoa.Name = "bt_Xoa";
            bt_Xoa.Size = new Size(207, 82);
            bt_Xoa.TabIndex = 9;
            bt_Xoa.Text = "Xóa";
            bt_Xoa.UseVisualStyleBackColor = false;
            bt_Xoa.Click += bt_Xoa_Click;
            // 
            // bt_Thoat
            // 
            bt_Thoat.BackColor = SystemColors.ControlText;
            bt_Thoat.ForeColor = SystemColors.Control;
            bt_Thoat.Location = new Point(885, 291);
            bt_Thoat.Margin = new Padding(4, 6, 4, 6);
            bt_Thoat.Name = "bt_Thoat";
            bt_Thoat.Size = new Size(207, 82);
            bt_Thoat.TabIndex = 8;
            bt_Thoat.Text = "Thoát";
            bt_Thoat.UseVisualStyleBackColor = false;
            bt_Thoat.Click += bt_Thoat_Click;
            // 
            // bt_ThucHien
            // 
            bt_ThucHien.BackColor = SystemColors.ControlText;
            bt_ThucHien.ForeColor = SystemColors.Control;
            bt_ThucHien.Location = new Point(315, 291);
            bt_ThucHien.Margin = new Padding(4, 6, 4, 6);
            bt_ThucHien.Name = "bt_ThucHien";
            bt_ThucHien.Size = new Size(207, 82);
            bt_ThucHien.TabIndex = 7;
            bt_ThucHien.Text = "Thực hiện";
            bt_ThucHien.UseVisualStyleBackColor = false;
            bt_ThucHien.Click += bt_ThucHien_Click;
            // 
            // cb_SoChuyen
            // 
            cb_SoChuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_SoChuyen.FormattingEnabled = true;
            cb_SoChuyen.Items.AddRange(new object[] { "Binary", "Decimal", "Hex" });
            cb_SoChuyen.Location = new Point(792, 180);
            cb_SoChuyen.Margin = new Padding(4, 6, 4, 6);
            cb_SoChuyen.Name = "cb_SoChuyen";
            cb_SoChuyen.Size = new Size(298, 45);
            cb_SoChuyen.TabIndex = 6;
            // 
            // cb_SoNhap
            // 
            cb_SoNhap.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_SoNhap.FormattingEnabled = true;
            cb_SoNhap.Items.AddRange(new object[] { "Binary", "Decimal", "Hex" });
            cb_SoNhap.Location = new Point(315, 180);
            cb_SoNhap.Margin = new Padding(4, 6, 4, 6);
            cb_SoNhap.Name = "cb_SoNhap";
            cb_SoNhap.Size = new Size(298, 45);
            cb_SoNhap.TabIndex = 5;
            // 
            // tbx_Nhap
            // 
            tbx_Nhap.Location = new Point(315, 88);
            tbx_Nhap.Margin = new Padding(4, 6, 4, 6);
            tbx_Nhap.Name = "tbx_Nhap";
            tbx_Nhap.Size = new Size(775, 44);
            tbx_Nhap.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(651, 195);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 38);
            label4.TabIndex = 3;
            label4.Text = "Sang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(158, 180);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 38);
            label2.TabIndex = 1;
            label2.Text = "Chọn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(122, 514);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 38);
            label3.TabIndex = 2;
            label3.Text = "Kết quả:";
            // 
            // tbx_KetQua
            // 
            tbx_KetQua.BackColor = SystemColors.ButtonHighlight;
            tbx_KetQua.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tbx_KetQua.Location = new Point(332, 504);
            tbx_KetQua.Margin = new Padding(4, 6, 4, 6);
            tbx_KetQua.Name = "tbx_KetQua";
            tbx_KetQua.ReadOnly = true;
            tbx_KetQua.Size = new Size(775, 44);
            tbx_KetQua.TabIndex = 5;
            // 
            // Lab1_BaiTap4
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 844);
            Controls.Add(tbx_KetQua);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            Name = "Lab1_BaiTap4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab1_BaiTap4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_SoNhap;
        private System.Windows.Forms.TextBox tbx_Nhap;
        private System.Windows.Forms.ComboBox cb_SoChuyen;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_ThucHien;
        private System.Windows.Forms.TextBox tbx_KetQua;
    }
}