using System;
using System.Windows.Forms;

namespace YoutubeTrendingApp
{
    public partial class YoutubeTrending : Form
    {
        public YoutubeTrending()
        {
            InitializeComponent();

            // Cấu hình cột cho DataGridView và độ rộng
            dataGridView.ColumnCount = 4;
            dataGridView.Columns[0].Name = "Title";
            dataGridView.Columns[1].Name = "Description";
            dataGridView.Columns[2].Name = "View Count";
            dataGridView.Columns[3].Name = "Link Video";
            dataGridView.Columns[3].Width = 300;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[1].Width = 250;
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
    }
}
