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
    public partial class Lab1_BaiTap2 : Form
    {
        public Lab1_BaiTap2()
        {
            InitializeComponent();
        }
        private void btn_Result_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            bool s1 = double.TryParse(tb_num1.Text, out num1);
            bool s2 = double.TryParse(tb_num2.Text, out num2);
            bool s3 = double.TryParse(tb_num3.Text, out num3);
            if (s1 && s2 && s3)
            {
                tb_max.Text = Math.Max(num1, Math.Max(num2, num3)).ToString();
                tb_min.Text = Math.Min(num1, Math.Min(num2, num3)).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ nhập số nguyên và thập phân", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            tb_num1.Clear();
            tb_num2.Clear();
            tb_num3.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LAB1_BaiTap2_Load(object sender, EventArgs e)
        {

        }
    }
}
