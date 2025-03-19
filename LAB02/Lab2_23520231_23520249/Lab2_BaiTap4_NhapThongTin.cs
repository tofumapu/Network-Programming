using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2_23520231_23520249
{
    public partial class Lab2_BaiTap4_NhapThongTin : Form
    {
        private List<SinhVien> danhSachSinhVien;
        public Lab2_BaiTap4_NhapThongTin()
        {
            InitializeComponent();
            danhSachSinhVien = new List<SinhVien>();
        }
        public class SinhVien
        {
            public required string HoTen;
            public required string MSSV;
            public required string SDT;
            public required double DiemToan;
            public required double DiemVan;
            public required double DiemTB;

            public double TinhDTB()
            {
                return 1.0 * (DiemToan + DiemVan) / 2;
            }
        }
        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào hợp lệ
            if (string.IsNullOrWhiteSpace(tb_HoTen.Text) ||
                string.IsNullOrWhiteSpace(tb_MSSV.Text) ||
                string.IsNullOrWhiteSpace(tb_SDT.Text) ||
                string.IsNullOrWhiteSpace(tb_DiemToan.Text) ||
                string.IsNullOrWhiteSpace(tb_DiemVan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(tb_DiemToan.Text, out double diemToan) || diemToan < 0 || diemToan > 10)
            {
                MessageBox.Show("Điểm toán không hợp lệ! Vui lòng nhập điểm từ 0 đến 10.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(tb_DiemVan.Text, out double diemVan) || diemVan < 0 || diemVan > 10)
            {
                MessageBox.Show("Điểm văn không hợp lệ! Vui lòng nhập điểm từ 0 đến 10.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SinhVien sv = new SinhVien()
            {
                HoTen = tb_HoTen.Text,
                MSSV = tb_MSSV.Text,
                SDT = tb_SDT.Text,
                DiemToan = double.Parse(tb_DiemToan.Text),
                DiemVan = double.Parse(tb_DiemVan.Text),
                DiemTB = 0
            };
            MessageBox.Show("Đã nhập thành công sinh viên: " + sv.HoTen);
            danhSachSinhVien.Add(sv);
            tb_HoTen.Text = "";
            tb_MSSV.Text = "";
            tb_SDT.Text = "";
            tb_DiemToan.Text = "";
            tb_DiemVan.Text = "";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            // Làm mới nội dung input.txt
            File.WriteAllText("input.txt", string.Empty);
            using StreamWriter writer = new StreamWriter("input.txt");
            try
            {
                foreach (SinhVien sv in danhSachSinhVien)
                {
                    writer.Write(sv.HoTen + ";");
                    writer.Write(sv.MSSV + ";");
                    writer.Write(sv.SDT + ";");
                    writer.Write(sv.DiemToan + ";");
                    writer.Write(sv.DiemVan);
                    writer.WriteLine();
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
