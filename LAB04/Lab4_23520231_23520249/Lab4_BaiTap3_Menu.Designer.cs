namespace Lab4_23520231_23520249
{
    partial class Lab4_BaiTap3_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab4_BaiTap3_Menu));
            btn_WeatherForecast = new Button();
            btn_YoutubeTrending = new Button();
            lbl_Title = new Label();
            SuspendLayout();
            // 
            // btn_WeatherForecast
            // 
            btn_WeatherForecast.Location = new Point(95, 155);
            btn_WeatherForecast.Name = "btn_WeatherForecast";
            btn_WeatherForecast.Size = new Size(266, 177);
            btn_WeatherForecast.TabIndex = 0;
            btn_WeatherForecast.Text = "Weather Forecast";
            btn_WeatherForecast.UseVisualStyleBackColor = true;
            btn_WeatherForecast.Click += btn_WeatherForecast_Click;
            // 
            // btn_YoutubeTrending
            // 
            btn_YoutubeTrending.Location = new Point(453, 155);
            btn_YoutubeTrending.Name = "btn_YoutubeTrending";
            btn_YoutubeTrending.Size = new Size(266, 177);
            btn_YoutubeTrending.TabIndex = 1;
            btn_YoutubeTrending.Text = "Youtube Trending";
            btn_YoutubeTrending.UseVisualStyleBackColor = true;
            btn_YoutubeTrending.Click += btn_YoutubeTrending_Click;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = SystemColors.ActiveCaption;
            lbl_Title.Location = new Point(322, 59);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(157, 45);
            lbl_Title.TabIndex = 2;
            lbl_Title.Text = "Bài Tập 3";
            // 
            // Lab4_BaiTap3_Menu
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Title);
            Controls.Add(btn_YoutubeTrending);
            Controls.Add(btn_WeatherForecast);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Lab4_BaiTap3_Menu";
            Text = "Lab4_BaiTap3_Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_WeatherForecast;
        private Button btn_YoutubeTrending;
        private Label lbl_Title;
    }
}