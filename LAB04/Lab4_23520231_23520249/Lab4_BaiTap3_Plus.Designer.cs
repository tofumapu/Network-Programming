namespace Lab4_23520231_23520249
{
    partial class Lab4_BaiTap3_Plus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab4_BaiTap3_Plus));
            btn_Load = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btn_Load
            // 
            btn_Load.Location = new Point(61, 36);
            btn_Load.Margin = new Padding(3, 4, 3, 4);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(145, 60);
            btn_Load.TabIndex = 0;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = true;
            btn_Load.Click += btn_Load_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(61, 140);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 72;
            dataGridView.RowTemplate.Height = 31;
            dataGridView.Size = new Size(2227, 1254);
            dataGridView.TabIndex = 1;
            // 
            // Lab4_BaiTap3_Plus
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2381, 1450);
            Controls.Add(dataGridView);
            Controls.Add(btn_Load);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lab4_BaiTap3_Plus";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Lab4_BaiTap3_Plus";
            FormClosed += Lab4_BaiTap3_Plus_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}