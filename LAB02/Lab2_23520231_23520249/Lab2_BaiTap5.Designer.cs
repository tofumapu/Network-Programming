namespace Lab2_23520231_23520249
{
    partial class Lab2_BaiTap5
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2_BaiTap5));
            button1 = new Button();
            tbx_Path = new TextBox();
            label1 = new Label();
            bt_Tim = new Button();
            bt_Thoat = new Button();
            listView_Show = new ListView();
            cl_Name = new ColumnHeader();
            cl_Date = new ColumnHeader();
            cl_Type = new ColumnHeader();
            cl_Size = new ColumnHeader();
            bt_Browse = new Button();
            imageList = new ImageList(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(168, 180);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(12, 15);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // tbx_Path
            // 
            tbx_Path.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Path.Location = new Point(97, 42);
            tbx_Path.Margin = new Padding(4, 5, 4, 5);
            tbx_Path.Name = "tbx_Path";
            tbx_Path.Size = new Size(894, 36);
            tbx_Path.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 29);
            label1.TabIndex = 3;
            label1.Text = "Path:";
            // 
            // bt_Tim
            // 
            bt_Tim.BackColor = Color.Transparent;
            bt_Tim.BackgroundImageLayout = ImageLayout.Zoom;
            bt_Tim.Location = new Point(1024, 35);
            bt_Tim.Margin = new Padding(4, 5, 4, 5);
            bt_Tim.Name = "bt_Tim";
            bt_Tim.Size = new Size(100, 79);
            bt_Tim.TabIndex = 4;
            bt_Tim.Text = "Tìm kiếm";
            bt_Tim.UseVisualStyleBackColor = false;
            bt_Tim.Click += bt_Tim_Click;
            // 
            // bt_Thoat
            // 
            bt_Thoat.Location = new Point(1351, 30);
            bt_Thoat.Margin = new Padding(4, 5, 4, 5);
            bt_Thoat.Name = "bt_Thoat";
            bt_Thoat.Size = new Size(167, 88);
            bt_Thoat.TabIndex = 5;
            bt_Thoat.Text = "Thoát";
            bt_Thoat.UseVisualStyleBackColor = true;
            bt_Thoat.Click += bt_Thoat_Click;
            // 
            // listView_Show
            // 
            listView_Show.Alignment = ListViewAlignment.Left;
            listView_Show.Columns.AddRange(new ColumnHeader[] { cl_Name, cl_Date, cl_Type, cl_Size });
            listView_Show.Location = new Point(17, 139);
            listView_Show.Margin = new Padding(4, 5, 4, 5);
            listView_Show.Name = "listView_Show";
            listView_Show.Size = new Size(1500, 899);
            listView_Show.TabIndex = 6;
            listView_Show.UseCompatibleStateImageBehavior = false;
            listView_Show.View = View.Details;
            // 
            // cl_Name
            // 
            cl_Name.Text = "Name";
            cl_Name.Width = 300;
            // 
            // cl_Date
            // 
            cl_Date.Text = "Date modified";
            cl_Date.Width = 250;
            // 
            // cl_Type
            // 
            cl_Type.Text = "Type";
            cl_Type.Width = 200;
            // 
            // cl_Size
            // 
            cl_Size.Text = "Size";
            cl_Size.Width = 100;
            // 
            // bt_Browse
            // 
            bt_Browse.Location = new Point(1154, 30);
            bt_Browse.Margin = new Padding(4, 5, 4, 5);
            bt_Browse.Name = "bt_Browse";
            bt_Browse.Size = new Size(167, 88);
            bt_Browse.TabIndex = 7;
            bt_Browse.Text = "Browse";
            bt_Browse.UseVisualStyleBackColor = true;
            bt_Browse.Click += bt_Browse_Click;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "page_paper_file_document_text_icon_228134.ico");
            imageList.Images.SetKeyName(1, "exe-file-outlined-symbol-of-stroke_icon-icons.com_57572.ico");
            imageList.Images.SetKeyName(2, "pdf_filetype_icon_227891.ico");
            imageList.Images.SetKeyName(3, "edge_browser_logo_icon_152998.ico");
            imageList.Images.SetKeyName(4, "file_type_vscode_icon_130084.ico");
            imageList.Images.SetKeyName(5, "file_type_powerpoint_icon_130245.ico");
            imageList.Images.SetKeyName(6, "file_type_word_icon_130070.ico");
            imageList.Images.SetKeyName(7, "file_type_excel_icon_130611.ico");
            imageList.Images.SetKeyName(8, "file_type_cpp_icon_130670.ico");
            imageList.Images.SetKeyName(9, "3643766-album-image-landscape-photo-photos-picture_113407.ico");
            imageList.Images.SetKeyName(10, "3643772-archive-archives-document-folder-open_113445 (1).ico");
            // 
            // Lab2_BaiTap5
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1545, 1270);
            Controls.Add(bt_Browse);
            Controls.Add(listView_Show);
            Controls.Add(bt_Thoat);
            Controls.Add(bt_Tim);
            Controls.Add(label1);
            Controls.Add(tbx_Path);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Lab2_BaiTap5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab2_BaiTap5";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbx_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Tim;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.ListView listView_Show;
        private System.Windows.Forms.Button bt_Browse;
        private System.Windows.Forms.ColumnHeader cl_Name;
        private System.Windows.Forms.ColumnHeader cl_Date;
        private System.Windows.Forms.ColumnHeader cl_Type;
        private System.Windows.Forms.ColumnHeader cl_Size;
        private System.Windows.Forms.ImageList imageList;
    }
}