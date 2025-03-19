using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_23520231_23520249
{
    public partial class Lab2_BaiTap3 : Form
    {
        private string selectedFilePath;
        public Lab2_BaiTap3()
        {
            InitializeComponent();
        }
        public void bt_Doc_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "txt files (*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK) // Kiểm tra nếu người dùng chọn file
                {
                    selectedFilePath = ofd.FileName; // Lưu đường dẫn file vào biến toàn cục
                    using (FileStream fs = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read))
                    {
                        StreamReader sr = new StreamReader(fs);
                        var str = sr.ReadToEnd();
                        rtbx_input.AppendText(str);
                    }
                }
            }
            catch (Exception tmp)
            {
                MessageBox.Show("Bạn chưa chọn file .txt !\n Caution: " + tmp.Message); // Cảnh báo khi xảy ra lỗi 
            }
        }
        static double Cal(string s)
        {
            double result = double.NaN;

            string pattern = @"\s*(\d+)\s*([+\-*/])\s*(\d+)\s*"; // Tách thành 3 nhóm đối tượng
            Match match = Regex.Match(s, pattern);// Tách chuỗi
            if (match.Success)// Nếu chuỗi đầu vào đủ 3 nhóm
            {
                double num1 = double.Parse(match.Groups[1].Value);//vị trí các số
                double num2 = double.Parse(match.Groups[3].Value);
                string op = match.Groups[2].Value;

                switch (op)
                {
                    case "+":
                        result = (num1 + num2);
                        break;
                    case "-":
                        result = (num1 - num2);
                        break;
                    case "*":
                        result = (num1 * num2);
                        break;
                    case "/":
                        if (num2 == 0 && op == "/")
                        {
                            MessageBox.Show("Không thể chia cho 0");
                            return double.NaN;
                        }
                        else result = (num1 / num2);
                        break;
                }
            }
            else
            {

                MessageBox.Show("Chuỗi không hợp lệ");
            }
            return result;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            rtbx_input.Clear();
            rtbx_output.Clear();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_Ghi_Click(object sender, EventArgs e)
        {
            using (StreamWriter writefileinput = new StreamWriter("DocFile.txt")) //Ghi đè file input bằng dữ liệu mới
            {
                writefileinput.WriteLine(rtbx_output.Text);
            }
            try
            {
                if (rtbx_output.Text.Length != 0)
                {
                    string str = rtbx_output.Text;
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "txt files (*.txt)|*.txt";
                    sfd.ShowDialog();
                    FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                    sw.WriteLine(str);
                    sw.Close();
                    fs.Close();
                    MessageBox.Show("Đã lưu file!");
                }
                else
                {
                    MessageBox.Show("Không có nội dung để lưu!");
                }
            }
            catch (Exception tmp)
            {
                MessageBox.Show("Bạn chưa chọn đường dẫn ghi file!\nCaution: " + tmp.Message);
            }
        }

        private void bt_Tinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Bạn chưa chọn file để tính toán!");
                return;
            }
            using (FileStream fs = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs);
                string input;
                while ((input = sr.ReadLine()) != null)
                {
                    rtbx_output.AppendText(input + "=" + Convert.ToString(Cal(input)) + Environment.NewLine);
                }
            }
        }


    }
}
