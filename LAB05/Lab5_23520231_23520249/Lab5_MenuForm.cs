using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_23520231_23520249
{
    public partial class Lab5_MenuForm : Form
    {
        public Lab5_MenuForm()
        {
            InitializeComponent();
        }
        private void btn_BaiTap1_Click(object sender, EventArgs e)
        {
            Lab5_BaiTap1 lab5_BaiTap1 = new Lab5_BaiTap1();
            lab5_BaiTap1.ShowDialog();
        }

        private void btn_BaiTap2_Click(object sender, EventArgs e)
        {
            Lab5_BaiTap2 lab5_BaiTap2 = new Lab5_BaiTap2();
            lab5_BaiTap2.ShowDialog();
        }
        private void btn_BaiTap3_Click(object sender, EventArgs e)
        {
            Lab5_BaiTap3 lab5_BaiTap3 = new Lab5_BaiTap3();
            lab5_BaiTap3.ShowDialog();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_BaiTap4_Click(object sender, EventArgs e)
        {
            //Lab5_BaiTap4 lab5_BaiTap4 = new Lab5_BaiTap4();
            //lab5_BaiTap4.ShowDialog();
        }
    }
}
