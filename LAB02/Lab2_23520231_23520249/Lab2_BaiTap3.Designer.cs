namespace Lab2_23520231_23520249
{
    partial class Lab2_BaiTap3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2_BaiTap3));
            bt_Doc = new Button();
            bt_Ghi = new Button();
            bt_Tinh = new Button();
            bt_Xoa = new Button();
            bt_Thoat = new Button();
            rtbx_input = new RichTextBox();
            rtbx_output = new RichTextBox();
            SuspendLayout();
            // 
            // bt_Doc
            // 
            bt_Doc.BackColor = SystemColors.InactiveCaption;
            bt_Doc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bt_Doc.Location = new Point(27, 22);
            bt_Doc.Margin = new Padding(4, 6, 4, 6);
            bt_Doc.Name = "bt_Doc";
            bt_Doc.Size = new Size(224, 82);
            bt_Doc.TabIndex = 0;
            bt_Doc.Text = "Đọc ";
            bt_Doc.UseVisualStyleBackColor = false;
            bt_Doc.Click += bt_Doc_Click;
            // 
            // bt_Ghi
            // 
            bt_Ghi.BackColor = SystemColors.InactiveCaption;
            bt_Ghi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bt_Ghi.Location = new Point(522, 22);
            bt_Ghi.Margin = new Padding(4, 6, 4, 6);
            bt_Ghi.Name = "bt_Ghi";
            bt_Ghi.Size = new Size(224, 82);
            bt_Ghi.TabIndex = 1;
            bt_Ghi.Text = "Ghi";
            bt_Ghi.UseVisualStyleBackColor = false;
            bt_Ghi.Click += bt_Ghi_Click;
            // 
            // bt_Tinh
            // 
            bt_Tinh.BackColor = SystemColors.InactiveCaption;
            bt_Tinh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bt_Tinh.Location = new Point(274, 22);
            bt_Tinh.Margin = new Padding(4, 6, 4, 6);
            bt_Tinh.Name = "bt_Tinh";
            bt_Tinh.Size = new Size(224, 82);
            bt_Tinh.TabIndex = 2;
            bt_Tinh.Text = "Tính";
            bt_Tinh.UseVisualStyleBackColor = false;
            bt_Tinh.Click += bt_Tinh_Click;
            // 
            // bt_Xoa
            // 
            bt_Xoa.BackColor = SystemColors.InactiveCaption;
            bt_Xoa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bt_Xoa.Location = new Point(771, 22);
            bt_Xoa.Margin = new Padding(4, 6, 4, 6);
            bt_Xoa.Name = "bt_Xoa";
            bt_Xoa.Size = new Size(224, 82);
            bt_Xoa.TabIndex = 3;
            bt_Xoa.Text = "Xóa";
            bt_Xoa.UseVisualStyleBackColor = false;
            bt_Xoa.Click += bt_Xoa_Click;
            // 
            // bt_Thoat
            // 
            bt_Thoat.BackColor = SystemColors.InactiveCaption;
            bt_Thoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bt_Thoat.Location = new Point(1017, 22);
            bt_Thoat.Margin = new Padding(4, 6, 4, 6);
            bt_Thoat.Name = "bt_Thoat";
            bt_Thoat.Size = new Size(224, 82);
            bt_Thoat.TabIndex = 4;
            bt_Thoat.Text = "Thoát";
            bt_Thoat.UseVisualStyleBackColor = false;
            bt_Thoat.Click += bt_Thoat_Click;
            // 
            // rtbx_input
            // 
            rtbx_input.Location = new Point(27, 141);
            rtbx_input.Margin = new Padding(4, 6, 4, 6);
            rtbx_input.Name = "rtbx_input";
            rtbx_input.ReadOnly = true;
            rtbx_input.Size = new Size(582, 677);
            rtbx_input.TabIndex = 5;
            rtbx_input.Text = "";
            // 
            // rtbx_output
            // 
            rtbx_output.Location = new Point(670, 141);
            rtbx_output.Margin = new Padding(4, 6, 4, 6);
            rtbx_output.Name = "rtbx_output";
            rtbx_output.Size = new Size(568, 677);
            rtbx_output.TabIndex = 6;
            rtbx_output.Text = "";
            // 
            // Lab2_BaiTap3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 859);
            Controls.Add(rtbx_output);
            Controls.Add(rtbx_input);
            Controls.Add(bt_Thoat);
            Controls.Add(bt_Xoa);
            Controls.Add(bt_Tinh);
            Controls.Add(bt_Ghi);
            Controls.Add(bt_Doc);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            Name = "Lab2_BaiTap3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab2_BaiTap3";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button bt_Doc;
        private System.Windows.Forms.Button bt_Ghi;
        private System.Windows.Forms.Button bt_Tinh;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.RichTextBox rtbx_input;
        private System.Windows.Forms.RichTextBox rtbx_output;
    }
}