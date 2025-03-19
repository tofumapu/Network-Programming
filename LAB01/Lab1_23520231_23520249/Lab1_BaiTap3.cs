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
    public partial class Lab1_BaiTap3 : Form
    {
        public Lab1_BaiTap3()
        {
            InitializeComponent();
        }
        private void btn_Result_Click_1(object sender, EventArgs e)
        {
            long GiaTri; // 9223372036854775807 = 2^63 - 1
            bool s = long.TryParse(tb_Input.Text, out GiaTri);
            if (!s)
            {
                MessageBox.Show("Vui lòng chỉ nhập số nguyên và dưới 2^63 nhé", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string[] SoDonVi = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] TapGiaTri = new string[] { "", "nghìn ", "triệu ", "tỷ " };

            bool isSoAm = false;
            if (GiaTri < 0)
            {
                GiaTri = -GiaTri;
                isSoAm = true;
            }
            string sGiaTri = GiaTri.ToString();
            int ViTri = sGiaTri.Length;
            string KetQua = " ";
            int DonVi = 0, Chuc = 0, Tram = 0;
            if (ViTri == 0)
            {
                KetQua = SoDonVi[0] + KetQua;
            }
            else
            {
                int iTapGiaTri = 0;
                while (ViTri > 0)
                {
                    // Kiem tra moi 3 chu so
                    // Theo thu tu tu don vi, chuc, tram, nghin, chuc nghin,.........
                    Chuc = -1;
                    Tram = -1;
                    DonVi = Convert.ToInt32(sGiaTri.Substring(ViTri - 1, 1));
                    ViTri--;
                    if (ViTri > 0)
                    {
                        Chuc = Convert.ToInt32(sGiaTri.Substring(ViTri - 1, 1));
                        ViTri--;
                        if (ViTri > 0)
                        {
                            Tram = Convert.ToInt32(sGiaTri.Substring(ViTri - 1, 1));
                            ViTri--;
                        }
                    }

                    if ((DonVi > 0) || (Chuc > 0) || (Tram > 0) || (iTapGiaTri == 3)) // iTapGiaTri = 3 khi lon hon 10^9
                    {
                        KetQua = TapGiaTri[iTapGiaTri] + KetQua;
                    }
                    iTapGiaTri++;
                    if (iTapGiaTri > 3) iTapGiaTri = 1; // reset va doc lai tu dau

                    if ((DonVi == 1) && (Chuc > 1))
                    {
                        KetQua = "một " + KetQua; // VD: 51 -> năm mươi một(mốt)
                    }
                    else
                    {
                        if (DonVi == 5 && Chuc > 0)
                        {
                            KetQua = "lăm " + KetQua; // VD: 55 -> năm mươi lăm
                        }
                        else if (DonVi > 0)
                        {
                            KetQua = SoDonVi[DonVi] + " " + KetQua; // not a special case
                        }
                    }
                    if (Chuc < 0) break; // Chuc = -1: input chi co 1 chu so
                    else
                    {
                        if (Chuc == 0) // khi hàng chục là 0
                        {
                            if (DonVi > 0)
                            {
                                KetQua = "lẻ " + KetQua; // VD: 102 -> một trăm lẻ hai
                            }
                        }
                        else
                        {
                            if (Chuc == 1) // khi hàng chục là 1
                            {
                                KetQua = "mười " + KetQua; // VD: 111 -> một trăm mười một
                            }
                            else
                            {
                                KetQua = SoDonVi[Chuc] + " mươi " + KetQua; // VD: 125 -> một trăm hai mươi lăm
                            }
                        }
                    }
                    if (Tram < 0) break; // Tram = -1: input chi co 2 chu so
                    else
                    {
                        if (Tram > 0 || Chuc > 0 || DonVi > 0)
                        {
                            KetQua = SoDonVi[Tram] + " trăm " + KetQua; // Đọc hàng trăm
                        }
                        //KetQua = " " + KetQua;
                    }


                }
            }
            KetQua = KetQua.Trim(); // Loai bo khoang trang thua
            if (isSoAm) KetQua = "Âm " + KetQua;
            tb_Output.Text = KetQua;
        }

        private void btn_Del_Click_1(object sender, EventArgs e)
        {
            tb_Input.Clear();
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Lab1_BaiTap3_Load(object sender, EventArgs e)
        {

        }
    }
}
