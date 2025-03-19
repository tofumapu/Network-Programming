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
    public partial class Lab1_BaiTap1 : Form
    {
        public Lab1_BaiTap1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            if (!Int32.TryParse(tb_FirstNum.Text.Trim(), out num1))
            {
                MessageBox.Show("Vui lòng nhập số Nguyên!");
                tb_FirstNum.Text = String.Empty;
            }
            else
            {
                if (!Int32.TryParse(tb_SecondNum.Text.Trim(), out num2))
                {
                    MessageBox.Show("Vui lòng nhập số Nguyên!");
                    tb_SecondNum.Text = String.Empty;
                }
                else
                {
                    num1 = Int32.Parse(tb_FirstNum.Text.Trim());
                    num2 = Int32.Parse(tb_SecondNum.Text.Trim());
                    sum = (long)num1 + num2;
                    tb_Result.Text = sum.ToString();
                }
            }
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            if (!Int32.TryParse(tb_FirstNum.Text.Trim(), out num1))
            {
                MessageBox.Show("Vui lòng nhập số Nguyên!");
                tb_FirstNum.Text = String.Empty;
            }
            else
            {
                if (!Int32.TryParse(tb_SecondNum.Text.Trim(), out num2))
                {
                    MessageBox.Show("Vui lòng nhập số Nguyên!");
                    tb_SecondNum.Text = String.Empty;
                }
                else
                {
                    num1 = Int32.Parse(tb_FirstNum.Text.Trim());
                    num2 = Int32.Parse(tb_SecondNum.Text.Trim());
                    sum = num1 - num2;
                    tb_Result.Text = sum.ToString();
                }
            }
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            if (!Int32.TryParse(tb_FirstNum.Text.Trim(), out num1)) 
            {
                MessageBox.Show("Vui lòng nhập số Nguyên!");
                tb_FirstNum.Text = String.Empty;    
            }
            else
            {
                if (!Int32.TryParse(tb_SecondNum.Text.Trim(), out num2))
                {
                    MessageBox.Show("Vui lòng nhập số Nguyên!");
                    tb_SecondNum.Text = String.Empty;
                }
                else
                {
                    num1 = Int32.Parse(tb_FirstNum.Text.Trim());
                    num2 = Int32.Parse(tb_SecondNum.Text.Trim());
                    sum = (long)num1 * num2;
                    tb_Result.Text = sum.ToString();
                }
            }
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            int num1, num2;
            Double sum = 0;
            if (!Int32.TryParse(tb_FirstNum.Text.Trim(), out num1))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_FirstNum.Text = String.Empty;
            }
            else
            {
                if (!Int32.TryParse(tb_SecondNum.Text.Trim(), out num2))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_SecondNum.Text = String.Empty;
                }
                else
                {
                    num1 = Int32.Parse(tb_FirstNum.Text.Trim());
                    num2 = Int32.Parse(tb_SecondNum.Text.Trim());
                    sum = 1.0 * num1 / num2;
                    tb_Result.Text = Math.Round(sum, 2).ToString();
                }
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            tb_FirstNum.Text = String.Empty;
            tb_SecondNum.Text = String.Empty;
            tb_Result.Text = String.Empty;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
