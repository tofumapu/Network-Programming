using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_23520231_23520249
{
    public partial class Lab4_BaiTap3_Plus : Form
    {
        public Lab4_BaiTap3_Plus()
        {
            InitializeComponent();
            // Cấu hình cột cho DataGridView và độ rộng
            dataGridView.ColumnCount = 4;
            dataGridView.Columns[0].Name = "Title";
            dataGridView.Columns[1].Name = "Description";
            dataGridView.Columns[2].Name = "View Count";
            dataGridView.Columns[3].Name = "Link Video";
            dataGridView.Columns[3].Width = 500;
            dataGridView.Columns[2].Width = 300;
            dataGridView.Columns[1].Width = 300;
            dataGridView.Columns[0].Width = 350;
        }
        private async void btn_Load_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();  // Xóa các hàng cũ trước khi tải mới
            var videos = await new YoutubeService().GetYoutubeTrendingVideos();

            // Xử lý ViewCount định dạng 1.000.000
            foreach (var video in videos)
            {
                video.ViewCount = string.Format("{0:#,0}", Convert.ToInt32(video.ViewCount));
            }
            foreach (var video in videos)
            {
                dataGridView.Rows.Add(video.Title, video.Description, video.ViewCount, video.LinkVideo);
            }

        }

        private void Lab4_BaiTap3_Plus_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
