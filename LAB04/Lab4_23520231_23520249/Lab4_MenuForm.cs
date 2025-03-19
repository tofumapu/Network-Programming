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
    public partial class Lab4_MenuForm : Form
    {
        public Lab4_MenuForm()
        {
            InitializeComponent();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_BaiTap1_Click(object sender, EventArgs e)
        {
            Lab4_BaiTap1 lab4_BaiTap1 = new Lab4_BaiTap1();
            lab4_BaiTap1.ShowDialog();
        }

        private void btn_BaiTap2_Click(object sender, EventArgs e)
        {
            Lab4_BaiTap2 lab4_BaiTap2 = new Lab4_BaiTap2();
            lab4_BaiTap2.ShowDialog();
        }
        private void btn_BaiTap3_Click(object sender, EventArgs e)
        {
            Lab4_BaiTap3_Menu lab4_BaiTap3 = new Lab4_BaiTap3_Menu();
            lab4_BaiTap3.ShowDialog();
        }
        private void btn_BaiTap4_Click(object sender, EventArgs e)
        {
            Lab4_BaiTap4 lab4_BaiTap4 = new Lab4_BaiTap4();
            lab4_BaiTap4.ShowDialog();
        }

        private void btn_BaiTap5_Click(object sender, EventArgs e)
        {
            //Lab2_BaiTap5 BaiTap5 = new Lab2_BaiTap5();
            //BaiTap5.ShowDialog();
        }
    }
}
