using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics; // Using for Pow function (in this circumstance),..
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_23520231_23520249
{
    public partial class Lab1_BaiTap4 : Form
    {
        public Lab1_BaiTap4()
        {
            InitializeComponent();
        }

        //Bin->Dec
        static BigInteger BintoDec(string bin)
        {
            foreach (char c in bin)
            {
                if (c != '0' && c != '1')
                {
                    MessageBox.Show("Vui lòng chỉ nhập số dạng nhị phân (0 và 1) để hiển thị kết quả chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            BigInteger result = 0;
            BigInteger baseValue = 1;

            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (bin[i] == '1')
                {
                    result += baseValue;
                }
                baseValue *= 2;
            }

            return result;
        }

        //Dec->Bin
        static string DectoBin(BigInteger dec)
        {
            string bin = "";
            int count = 0;
            for (int i = 63; i >= 0; i--)
            {
                if ((BigInteger)dec >= (BigInteger)Math.Pow(2, i))
                {
                    dec = dec - (BigInteger)Math.Pow(2, i);
                    bin += "1";
                    count++;
                }
                else if (count != 0) bin += "0";
            }
            return bin;
        }

        //Hex->Dec
        static BigInteger HextoDec(string hexstring)
        {
            BigInteger result = 0;
            int somu = hexstring.Length - 1;
            hexstring = hexstring.ToUpper(); // Fix all cases to Upper when user typing lowercase
            foreach (char c in hexstring)
            {
                int digit = char.IsDigit(c) ? c - '0' : c - 'A' + 10;
                result += digit * (int)Math.Pow(16, somu);
                somu--;
            }

            return result;
        }

        //Bin->Hex
        static string BintoHex(string bin)
        {
            int decValue = 0;
            int power = bin.Length - 1;

            foreach (char c in bin)
            {
                decValue += (c - '0') * (int)Math.Pow(2, power);
                power--;
            }

            string hexdecString = Convert.ToString(decValue, 16);
            return hexdecString.ToUpper();

        }

        //ThucHien_func
        private void bt_ThucHien_Click(object sender, EventArgs e)
        {
            BigInteger num3 = 0;
            bool s1 = BigInteger.TryParse(tbx_Nhap.Text.Trim(), out num3);
            if (cb_SoNhap.SelectedIndex != 2 && s1 == false) MessageBox.Show("Số vừa nhập không hợp lệ!");
            if (cb_SoNhap.SelectedIndex == cb_SoChuyen.SelectedIndex)
            {
                tbx_KetQua.Text = tbx_Nhap.Text;
            }
            if (cb_SoNhap.SelectedIndex == 0 && cb_SoChuyen.SelectedIndex == 1)
            {
                tbx_KetQua.Text = BintoDec(tbx_Nhap.Text.Trim()).ToString();
            }
            if (cb_SoNhap.SelectedIndex == 0 && cb_SoChuyen.SelectedIndex == 2)
            {
                tbx_KetQua.Text = BintoHex(tbx_Nhap.Text.Trim()).ToString();
            }
            if (cb_SoNhap.SelectedIndex == 1 && cb_SoChuyen.SelectedIndex == 0)
            {
                tbx_KetQua.Text = DectoBin(num3).ToString();
            }
            if (cb_SoNhap.SelectedIndex == 1 && cb_SoChuyen.SelectedIndex == 2)
            {
                tbx_KetQua.Text = BintoHex(DectoBin(num3)).ToString();
            }
            if (cb_SoNhap.SelectedIndex == 2 & cb_SoChuyen.SelectedIndex == 1)
            {

                tbx_KetQua.Text = HextoDec(tbx_Nhap.Text.Trim()).ToString();
            }
            if (cb_SoNhap.SelectedIndex == 2 && cb_SoChuyen.SelectedIndex == 0)
            {
                tbx_KetQua.Text = DectoBin(HextoDec(tbx_Nhap.Text.Trim())).ToString();
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            tbx_Nhap.Text = String.Empty;
            tbx_KetQua.Text = String.Empty;
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}




