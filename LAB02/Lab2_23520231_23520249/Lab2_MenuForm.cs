using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_23520231_23520249
{
    public partial class Lab2_MenuForm : Form
    {
        public Lab2_MenuForm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_BaiTap1_Click(object sender, EventArgs e)
        {
            Lab2_BaiTap1 BaiTap1 = new Lab2_BaiTap1();
            BaiTap1.ShowDialog();
        }

        private void btn_BaiTap2_Click(object sender, EventArgs e)
        {
            Lab2_BaiTap2 BaiTap2 = new Lab2_BaiTap2();
            BaiTap2.ShowDialog();
        }

        private void btn_BaiTap4_Click(object sender, EventArgs e)
        {
            Lab2_BaiTap4 BaiTap4 = new Lab2_BaiTap4();
            BaiTap4.ShowDialog();
        }

        private void btn_BaiTap5_Click(object sender, EventArgs e)
        {
            Lab2_BaiTap5 BaiTap5 = new Lab2_BaiTap5();
            BaiTap5.ShowDialog();
        }

        private void btn_BaiTap3_Click(object sender, EventArgs e)
        {
            Lab2_BaiTap3 BaiTap3 = new Lab2_BaiTap3();
            BaiTap3.ShowDialog();
        }
    }
}
