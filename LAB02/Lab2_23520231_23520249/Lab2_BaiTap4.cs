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
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace Lab2_23520231_23520249
{
    public partial class Lab2_BaiTap4 : Form
    {
        private List<Lab2_BaiTap4_NhapThongTin.SinhVien> danhSachSinhVien = new List<Lab2_BaiTap4_NhapThongTin.SinhVien>();

        public Lab2_BaiTap4()
        {
            InitializeComponent();
        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            Lab2_BaiTap4_NhapThongTin NhapThongTin = new Lab2_BaiTap4_NhapThongTin();
            NhapThongTin.ShowDialog();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 5)
                    {
                        var sv = new Lab2_BaiTap4_NhapThongTin.SinhVien
                        {
                            HoTen = parts[0],
                            MSSV = parts[1],
                            SDT = parts[2],
                            DiemToan = double.Parse(parts[3]),
                            DiemVan = double.Parse(parts[4]),
                            DiemTB = (double.Parse(parts[3]) + double.Parse(parts[4])) / 2
                        };
                        danhSachSinhVien.Add(sv);
                    }
                }
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            using (var workbook = new XSSFWorkbook())
            {
                var sheet = workbook.CreateSheet("Danh sách sinh viên");

                // Tạo tiêu đề
                var headerRow = sheet.CreateRow(0);
                headerRow.CreateCell(0).SetCellValue("Họ tên");
                headerRow.CreateCell(1).SetCellValue("MSSV");
                headerRow.CreateCell(2).SetCellValue("Số điện thoại");
                headerRow.CreateCell(3).SetCellValue("Điểm toán");
                headerRow.CreateCell(4).SetCellValue("Điểm văn");
                headerRow.CreateCell(5).SetCellValue("Điểm trung bình");

                // Thêm dữ liệu sinh viên
                int rowIndex = 1;
                foreach (var sv in danhSachSinhVien)
                {
                    var row = sheet.CreateRow(rowIndex++);
                    row.CreateCell(0).SetCellValue(sv.HoTen);
                    row.CreateCell(1).SetCellValue(sv.MSSV);
                    row.CreateCell(2).SetCellValue(sv.SDT);
                    row.CreateCell(3).SetCellValue(sv.DiemToan);
                    row.CreateCell(4).SetCellValue(sv.DiemVan);
                    row.CreateCell(5).SetCellValue(sv.DiemTB);
                }

                // Lưu workbook vào file
                using (var fileStream = new FileStream("output.xlsx", FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(fileStream);
                }
            }
        }

        private void btn_HienThiThongTin_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("output.xlsx", FileMode.Open, FileAccess.Read))
            {
                IWorkbook workbook = new XSSFWorkbook(fs);
                ISheet sheet = workbook.GetSheetAt(0);

                // Tạo một DataTable để lưu trữ dữ liệu
                DataTable dt = new DataTable();

                // Khởi tạo các hàng, cột cho dataTable
                IRow headerRow = sheet.GetRow(0);
                for (int i = 0; i < headerRow.LastCellNum; i++)
                {
                    dt.Columns.Add(headerRow.GetCell(i).StringCellValue);
                }

                // Đọc toàn bộ file vào dataTable
                for (int i = 1; i <= sheet.LastRowNum; i++)
                {
                    IRow row = sheet.GetRow(i);
                    DataRow dataRow = dt.NewRow();
                    for (int j = 0; j < row.LastCellNum; j++)
                    {
                        if (row.GetCell(j) != null)
                        {
                            dataRow[j] = row.GetCell(j).ToString();
                        }
                    }
                    dt.Rows.Add(dataRow);
                }

                // Đẩy dữ liệu từ dataTable cho DataGridView
                dataGridView_SinhVien.DataSource = dt;
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
