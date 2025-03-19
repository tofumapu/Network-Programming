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
    public partial class Lab4_BaiTap3_Menu : Form
    {
        public Lab4_BaiTap3_Menu()
        {
            InitializeComponent();
        }

        private void btn_WeatherForecast_Click(object sender, EventArgs e)
        {
            // Gọi Lab4_BaiTap3
            Lab4_BaiTap3 lab4_BaiTap3 = new Lab4_BaiTap3();
            lab4_BaiTap3.ShowDialog();
        }

        private void btn_YoutubeTrending_Click(object sender, EventArgs e)
        {
            Lab4_BaiTap3_Plus lab4_BaiTap3_Plus = new Lab4_BaiTap3_Plus();
            lab4_BaiTap3_Plus.ShowDialog();
        }
    }
}
