using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_23520231_23520249
{
    public partial class Lab1_MenuForm : Form
    {
        public Lab1_MenuForm()
        {
            InitializeComponent();
        }

        private void btn_BaiTap1_Click(object sender, EventArgs e)
        {
            Lab1_BaiTap1 BaiTap1 = new Lab1_BaiTap1();
            BaiTap1.ShowDialog();
        }

        private void btn_BaiTap2_Click(object sender, EventArgs e)
        {
            Lab1_BaiTap2 BaiTap2 = new Lab1_BaiTap2();
            BaiTap2.ShowDialog();
        }

        private void btn_BaiTap3_Click(object sender, EventArgs e)
        {
            Lab1_BaiTap3 BaiTap3 = new Lab1_BaiTap3();
            BaiTap3.ShowDialog();
        }

        private void btn_BaiTap4_Click(object sender, EventArgs e)
        {
            Lab1_BaiTap4 BaiTap4 = new Lab1_BaiTap4();
            BaiTap4.ShowDialog();
        }

        private void btn_BaiTap5_Click(object sender, EventArgs e)
        {
            Lab1_BaiTap5 BaiTap5 = new Lab1_BaiTap5();
            BaiTap5.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
