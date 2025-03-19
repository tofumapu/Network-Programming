namespace ResumeInformation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            linkLabel1 = new LinkLabel();
            lblHoTen = new Label();
            lblNgaySinh = new Label();
            lblMSSV = new Label();
            lblTruongHoc = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.Info;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(127, 440);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(79, 30);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Chi tiết";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.BackColor = SystemColors.Info;
            lblHoTen.Location = new Point(457, 112);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(76, 30);
            lblHoTen.TabIndex = 3;
            lblHoTen.Text = "Họ tên";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.BackColor = SystemColors.Info;
            lblNgaySinh.Location = new Point(457, 187);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(106, 30);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblMSSV
            // 
            lblMSSV.AutoSize = true;
            lblMSSV.BackColor = SystemColors.Info;
            lblMSSV.Location = new Point(457, 271);
            lblMSSV.Name = "lblMSSV";
            lblMSSV.Size = new Size(67, 30);
            lblMSSV.TabIndex = 5;
            lblMSSV.Text = "MSSV";
            // 
            // lblTruongHoc
            // 
            lblTruongHoc.AutoSize = true;
            lblTruongHoc.BackColor = SystemColors.Info;
            lblTruongHoc.Location = new Point(457, 355);
            lblTruongHoc.Name = "lblTruongHoc";
            lblTruongHoc.Size = new Size(148, 30);
            lblTruongHoc.TabIndex = 6;
            lblTruongHoc.Text = "Chuyên ngành";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = SystemColors.Info;
            linkLabel2.ForeColor = SystemColors.ActiveCaptionText;
            linkLabel2.LinkColor = Color.Red;
            linkLabel2.Location = new Point(49, 561);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(241, 30);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "dangka3789@gmail.com";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = SystemColors.Info;
            linkLabel3.LinkColor = Color.Red;
            linkLabel3.Location = new Point(110, 604);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(115, 30);
            linkLabel3.TabIndex = 8;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Nhật Đăng";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Info;
            label5.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(169, 21);
            label5.Name = "label5";
            label5.Size = new Size(369, 68);
            label5.TabIndex = 2;
            label5.Text = "Sơ Yếu Lý Lịch";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(623, 112);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(372, 35);
            textBox1.TabIndex = 10;
            textBox1.Text = "Nguyễn Lê Nhật Đăng";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(623, 187);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(372, 35);
            textBox2.TabIndex = 10;
            textBox2.Text = "08/02/2005";
            textBox2.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(623, 266);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(372, 35);
            textBox3.TabIndex = 10;
            textBox3.Text = "23520231";
            textBox3.TextChanged += textBox1_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(623, 352);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(372, 73);
            textBox4.TabIndex = 10;
            textBox4.Text = "Mạng máy tính và truyền thông dữ liệu";
            textBox4.TextChanged += textBox1_TextChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(-2, -1);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Highlight;
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(linkLabel2);
            splitContainer1.Panel1.Controls.Add(linkLabel3);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Info;
            splitContainer1.Panel2.Controls.Add(textBox5);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(1060, 657);
            splitContainer1.SplitterDistance = 352;
            splitContainer1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 301);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(269, 456);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(372, 135);
            textBox5.TabIndex = 10;
            textBox5.Text = "Nghe nhạc\r\nTập Gym\r\nHọc tập\r\nXem mèo\r\n\r\n";
            textBox5.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Location = new Point(103, 456);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 6;
            label1.Text = "Sở thích";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = linkLabel1;
            ClientSize = new Size(1056, 656);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblTruongHoc);
            Controls.Add(lblMSSV);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblHoTen);
            Controls.Add(linkLabel1);
            Controls.Add(splitContainer1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resume Information";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private LinkLabel linkLabel1;
        private Label lblHoTen;
        private Label lblNgaySinh;
        private Label lblMSSV;
        private Label lblTruongHoc;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private SplitContainer splitContainer1;
        private TextBox textBox5;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
