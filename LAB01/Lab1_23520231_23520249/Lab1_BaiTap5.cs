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
    public partial class Lab1_BaiTap5 : Form
    {
        public Lab1_BaiTap5()
        {
            InitializeComponent();
        }
        // Kiem tra diem hop le trong chuoi
        static bool KiemTraHopLe(string[] strDiems)
        {
            foreach (string strDiem in strDiems)
            {
                if (!double.TryParse(strDiem, out double Diem) || Diem < 0 || Diem > 10)
                {
                    return false;
                }
            }
            return true;
        }
        // Phan loai hoc sinh : ClassifyStudent
        static string PhanLoaiHocSinh(double DiemTB, double[] Diems)
        {
            if (DiemTB >= 8 && !Diems.Any(score => score < 6.5))
            {
                return "Giỏi";
            }
            else if (DiemTB >= 6.5 && !Diems.Any(score => score < 5))
            {
                return "Khá";
            }
            else if (DiemTB >= 5 && !Diems.Any(score => score < 3.5))
            {
                return "TB";
            }
            else if (DiemTB >= 3.5 && !Diems.Any(score => score < 2))
            {
                return "Yếu";
            }
            else
            {
                return "Kém";
            }
        }

        private void btn_Excute_Click(object sender, EventArgs e)
        {
            // Refresh moi lan nhap
            gb_OutputList.Controls.Clear();
            lbl_OutputDTB.Controls.Clear();
            lbl_OutputMax.Controls.Clear();
            lbl_OutputMin.Controls.Clear();
            lbl_OutputCountPass.Controls.Clear();
            lbl_OutputCountFail.Controls.Clear();
            lbl_OutputClassify.Controls.Clear();

            tbx_Input.Text = tbx_Input.Text.Trim().Replace(',', ' '); // Xoa bo khoang trang de xu li
            string chuoiDiem = tbx_Input.Text;
            string[] strDiems = chuoiDiem.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            bool KiemTraChuoiHopLe = KiemTraHopLe(strDiems);
            if (!KiemTraChuoiHopLe)
            {
                MessageBox.Show("Chuỗi điểm không hợp lệ vui lòng nhập theo đúng thứ tự\n VD: 2.5, 3, 4, 5", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double[] Diems = Array.ConvertAll(strDiems, double.Parse);


                // P1: Xu li in ra man hinh
                TableLayoutPanel DanhSach = new TableLayoutPanel();
                DanhSach.Dock = DockStyle.Fill;
                DanhSach.ColumnCount = 5;
                for (int i = 0; i < Diems.Length; i++)
                {
                    Label lbl = new Label();
                    lbl.Text = $"Môn {i + 1}: {Math.Round(Diems[i], 2)}đ";
                    lbl.Location = new Point(10, 30 * i + 30);
                    lbl.AutoSize = true;
                    DanhSach.Controls.Add(lbl, i % 5, i / 5);
                }
                gb_OutputList.Controls.Add(DanhSach);

                // P2: Xu li cac thong so
                double DiemTB = Diems.Average();
                lbl_OutputDTB.Text = Math.Round(DiemTB, 2).ToString();

                double DiemCaoNhat = Diems.Max();
                double DiemThapNhat = Diems.Min();
                lbl_OutputMax.Text = Math.Round(DiemCaoNhat, 2).ToString() + " đ";
                lbl_OutputMin.Text = Math.Round(DiemThapNhat, 2).ToString() + " đ";
                lbl_OutputCountPass.Text = Diems.Count(score => score >= 5).ToString() + " môn";
                lbl_OutputCountFail.Text = Diems.Count(score => score < 5).ToString() + " môn";
                lbl_OutputClassify.Text = PhanLoaiHocSinh(DiemTB, Diems);

            }
        }

        private void btn_Retype_Click(object sender, EventArgs e)
        {
            tbx_Input.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
