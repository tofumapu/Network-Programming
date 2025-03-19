using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_23520231_23520249
{
    public partial class Lab2_BaiTap1 : Form
    {
        public Lab2_BaiTap1()
        {
            InitializeComponent();
        }
        private void bt_Doc_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text (*.txt)|*.txt";//lọc file .txt
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                rtbx_Show.Text = sr.ReadToEnd();
                fs.Close();
            }
            catch (Exception tmp)
            {
                MessageBox.Show("Bạn chưa chọn file .txt !\nCaution: " + tmp.Message);//cảnh báo khi xảy ra lỗi 
            }
        }

        //Ghi file với toàn bộ ký tự được uppercase
        private void bt_Ghi_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtbx_Show.Text.Length != 0)
                {
                    string str = rtbx_Show.Text;
                    str = str.ToUpper();//Viết hoa toàn bộ ký tự
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "txt files (*.txt)|*.txt";
                    sfd.ShowDialog();
                    FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                    sw.WriteLine(str);
                    sw.Close();
                    fs.Close();
                }
                else
                {
                    MessageBox.Show("Không có nội dung để ghi!");
                }
            }
            catch (Exception tmp)
            {
                MessageBox.Show("Bạn chưa chọn đường dẫn ghi file!\nCaution: " + tmp.Message);
            }
        }
        //ẩn form
        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
