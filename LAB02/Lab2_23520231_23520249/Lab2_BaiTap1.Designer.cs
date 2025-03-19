using System.Runtime.Intrinsics.X86;

namespace Lab2_23520231_23520249
{
    partial class Lab2_BaiTap1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2_BaiTap1));
            bt_Doc = new Button();
            bt_Ghi = new Button();
            bt_Thoat = new Button();
            rtbx_Show = new RichTextBox();
            SuspendLayout();
            // 
            // bt_Doc
            // 
            bt_Doc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bt_Doc.Location = new Point(74, 142);
            bt_Doc.Margin = new Padding(4, 6, 4, 6);
            bt_Doc.Name = "bt_Doc";
            bt_Doc.Size = new Size(256, 109);
            bt_Doc.TabIndex = 0;
            bt_Doc.Text = "Đọc File";
            bt_Doc.UseVisualStyleBackColor = true;
            bt_Doc.Click += bt_Doc_Click;
            // 
            // bt_Ghi
            // 
            bt_Ghi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bt_Ghi.Location = new Point(74, 332);
            bt_Ghi.Margin = new Padding(4, 6, 4, 6);
            bt_Ghi.Name = "bt_Ghi";
            bt_Ghi.Size = new Size(256, 109);
            bt_Ghi.TabIndex = 1;
            bt_Ghi.Text = "Ghi File";
            bt_Ghi.UseVisualStyleBackColor = true;
            bt_Ghi.Click += bt_Ghi_Click;
            // 
            // bt_Thoat
            // 
            bt_Thoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Thoat.Location = new Point(126, 544);
            bt_Thoat.Margin = new Padding(4, 6, 4, 6);
            bt_Thoat.Name = "bt_Thoat";
            bt_Thoat.Size = new Size(153, 82);
            bt_Thoat.TabIndex = 2;
            bt_Thoat.Text = "Thoát";
            bt_Thoat.UseVisualStyleBackColor = true;
            bt_Thoat.Click += bt_Thoat_Click;
            // 
            // rtbx_Show
            // 
            rtbx_Show.Location = new Point(408, 90);
            rtbx_Show.Margin = new Padding(4, 6, 4, 6);
            rtbx_Show.Name = "rtbx_Show";
            rtbx_Show.Size = new Size(694, 625);
            rtbx_Show.TabIndex = 3;
            rtbx_Show.Text = "";
            // 
            // Lab2_BaiTap1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 844);
            Controls.Add(rtbx_Show);
            Controls.Add(bt_Thoat);
            Controls.Add(bt_Ghi);
            Controls.Add(bt_Doc);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            Name = "Lab2_BaiTap1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab2_BaiTap1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button bt_Doc;
        private System.Windows.Forms.Button bt_Ghi;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.RichTextBox rtbx_Show;
    }
}