namespace Lab4_23520231_23520249
{
    partial class Lab4_BaiTap3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab4_BaiTap3));
            bt_Load = new Button();
            tb_Vi = new TextBox();
            tb_Kinh = new TextBox();
            label1 = new Label();
            label2 = new Label();
            GridView_Show = new DataGridView();
            time = new DataGridViewTextBoxColumn();
            temperature_2m = new DataGridViewTextBoxColumn();
            relative_humidity_2m = new DataGridViewTextBoxColumn();
            windspeed_10m = new DataGridViewTextBoxColumn();
            pressure_msl = new DataGridViewTextBoxColumn();
            label3 = new Label();
            cbx_CityList = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)GridView_Show).BeginInit();
            SuspendLayout();
            // 
            // bt_Load
            // 
            bt_Load.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bt_Load.Location = new Point(1088, 32);
            bt_Load.Margin = new Padding(4, 5, 4, 5);
            bt_Load.Name = "bt_Load";
            bt_Load.Size = new Size(171, 124);
            bt_Load.TabIndex = 0;
            bt_Load.Text = "LOAD";
            bt_Load.UseVisualStyleBackColor = true;
            bt_Load.Click += bt_Load_Click;
            // 
            // tb_Vi
            // 
            tb_Vi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tb_Vi.Location = new Point(792, 38);
            tb_Vi.Margin = new Padding(4, 5, 4, 5);
            tb_Vi.Name = "tb_Vi";
            tb_Vi.Size = new Size(266, 39);
            tb_Vi.TabIndex = 1;
            // 
            // tb_Kinh
            // 
            tb_Kinh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tb_Kinh.Location = new Point(792, 100);
            tb_Kinh.Margin = new Padding(4, 5, 4, 5);
            tb_Kinh.Name = "tb_Kinh";
            tb_Kinh.Size = new Size(266, 39);
            tb_Kinh.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(641, 104);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 32);
            label1.TabIndex = 3;
            label1.Text = "Kinh Độ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(641, 41);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 4;
            label2.Text = "Vĩ Độ";
            // 
            // GridView_Show
            // 
            GridView_Show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridView_Show.Columns.AddRange(new DataGridViewColumn[] { time, temperature_2m, relative_humidity_2m, windspeed_10m, pressure_msl });
            GridView_Show.Location = new Point(17, 188);
            GridView_Show.Margin = new Padding(4, 5, 4, 5);
            GridView_Show.Name = "GridView_Show";
            GridView_Show.RowHeadersWidth = 51;
            GridView_Show.RowTemplate.Height = 24;
            GridView_Show.Size = new Size(1241, 634);
            GridView_Show.TabIndex = 5;
            // 
            // time
            // 
            time.DataPropertyName = "time";
            time.HeaderText = "Thời điểm";
            time.MinimumWidth = 6;
            time.Name = "time";
            time.Width = 175;
            // 
            // temperature_2m
            // 
            temperature_2m.DataPropertyName = "temperature_2m";
            temperature_2m.HeaderText = "Nhiệt độ (°C)";
            temperature_2m.MinimumWidth = 6;
            temperature_2m.Name = "temperature_2m";
            temperature_2m.Width = 175;
            // 
            // relative_humidity_2m
            // 
            relative_humidity_2m.DataPropertyName = "relative_humidity_2m";
            relative_humidity_2m.HeaderText = "Độ ẩm (%)";
            relative_humidity_2m.MinimumWidth = 6;
            relative_humidity_2m.Name = "relative_humidity_2m";
            relative_humidity_2m.Width = 90;
            // 
            // windspeed_10m
            // 
            windspeed_10m.DataPropertyName = "windspeed_10m";
            windspeed_10m.HeaderText = "Tốc độ gió (m/s)";
            windspeed_10m.MinimumWidth = 6;
            windspeed_10m.Name = "windspeed_10m";
            windspeed_10m.Width = 125;
            // 
            // pressure_msl
            // 
            pressure_msl.DataPropertyName = "pressure_msl";
            pressure_msl.HeaderText = "Áp suất (hPa)";
            pressure_msl.MinimumWidth = 6;
            pressure_msl.Name = "pressure_msl";
            pressure_msl.Width = 175;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 55);
            label3.Name = "label3";
            label3.Size = new Size(134, 29);
            label3.TabIndex = 6;
            label3.Text = "Thành phố:";
            // 
            // cbx_CityList
            // 
            cbx_CityList.FormattingEnabled = true;
            cbx_CityList.Location = new Point(165, 51);
            cbx_CityList.Margin = new Padding(3, 4, 3, 4);
            cbx_CityList.Name = "cbx_CityList";
            cbx_CityList.Size = new Size(455, 38);
            cbx_CityList.TabIndex = 7;
            cbx_CityList.SelectedIndexChanged += cbx_CityList_SelectedIndexChanged;
            // 
            // Lab4_BaiTap3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 844);
            Controls.Add(cbx_CityList);
            Controls.Add(label3);
            Controls.Add(GridView_Show);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_Kinh);
            Controls.Add(tb_Vi);
            Controls.Add(bt_Load);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Lab4_BaiTap3";
            Text = "Lab4_BaiTap3";
            FormClosed += Lab4_BaiTap3_FormClosed;
            ((System.ComponentModel.ISupportInitialize)GridView_Show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.TextBox tb_Vi;
        private System.Windows.Forms.TextBox tb_Kinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridView_Show;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperature_2m;
        private System.Windows.Forms.DataGridViewTextBoxColumn relative_humidity_2m;
        private System.Windows.Forms.DataGridViewTextBoxColumn windspeed_10m;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressure_msl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_CityList;
    }
}