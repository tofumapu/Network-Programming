namespace Lab4_23520231_23520249
{
    partial class Lab4_BaiTap1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab4_BaiTap1));
            tb_url = new TextBox();
            bt_Load = new Button();
            rtb_HTML = new RichTextBox();
            GridView_Header = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            Header = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)GridView_Header).BeginInit();
            SuspendLayout();
            // 
            // tb_url
            // 
            tb_url.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tb_url.Location = new Point(50, 22);
            tb_url.Margin = new Padding(4, 6, 4, 6);
            tb_url.Name = "tb_url";
            tb_url.Size = new Size(1048, 39);
            tb_url.TabIndex = 0;
            // 
            // bt_Load
            // 
            bt_Load.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            bt_Load.Location = new Point(1149, 15);
            bt_Load.Margin = new Padding(4, 6, 4, 6);
            bt_Load.Name = "bt_Load";
            bt_Load.Size = new Size(182, 71);
            bt_Load.TabIndex = 1;
            bt_Load.Text = "Load";
            bt_Load.UseVisualStyleBackColor = true;
            bt_Load.Click += bt_Load_Click;
            // 
            // rtb_HTML
            // 
            rtb_HTML.Location = new Point(34, 118);
            rtb_HTML.Margin = new Padding(4, 6, 4, 6);
            rtb_HTML.Name = "rtb_HTML";
            rtb_HTML.Size = new Size(612, 790);
            rtb_HTML.TabIndex = 2;
            rtb_HTML.Text = "";
            // 
            // GridView_Header
            // 
            GridView_Header.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridView_Header.Columns.AddRange(new DataGridViewColumn[] { STT, Header, Value });
            GridView_Header.Location = new Point(717, 118);
            GridView_Header.Margin = new Padding(4, 6, 4, 6);
            GridView_Header.Name = "GridView_Header";
            GridView_Header.RowHeadersWidth = 51;
            GridView_Header.RowTemplate.Height = 24;
            GridView_Header.Size = new Size(614, 793);
            GridView_Header.TabIndex = 3;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.Width = 50;
            // 
            // Header
            // 
            Header.HeaderText = "Header";
            Header.MinimumWidth = 6;
            Header.Name = "Header";
            Header.Width = 125;
            // 
            // Value
            // 
            Value.HeaderText = "Value";
            Value.MinimumWidth = 6;
            Value.Name = "Value";
            Value.Width = 300;
            // 
            // Lab4_BaiTap1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 934);
            Controls.Add(GridView_Header);
            Controls.Add(rtb_HTML);
            Controls.Add(bt_Load);
            Controls.Add(tb_url);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            Name = "Lab4_BaiTap1";
            Text = "Lab4_BaiTap1";
            FormClosed += Lab4_BaiTap1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)GridView_Header).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.RichTextBox rtb_HTML;
        private System.Windows.Forms.DataGridView GridView_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}