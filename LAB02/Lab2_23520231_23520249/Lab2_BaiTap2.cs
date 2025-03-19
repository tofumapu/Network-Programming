using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class Lab2_BaiTap2 : Form
    {
        public Lab2_BaiTap2()
        {
            InitializeComponent();
        }

        private void btn_ReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                string content = streamReader.ReadToEnd();
                rtbx_Output.Text = content;
                tbx_FileName.Text = openFileDialog.SafeFileName;
                tbx_URL.Text = openFileDialog.FileName;
                // Count Line
                int lineCount = 0;
                using (StreamReader streamReaderLine = new StreamReader(openFileDialog.FileName))
                {
                    while (!streamReaderLine.EndOfStream)
                    {
                        streamReaderLine.ReadLine();
                        lineCount++;
                    }
                }
                tbx_CountLine.Text = lineCount.ToString();
                content = content.Replace("\r\n", "\r"); // Chuyển đổi xuống dòng
                content = content.Replace('\r', ' '); // Thay thế ký tự xuống dòng bằng khoảng trắng
                string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int wordCount = source.Length; // Sử dụng Length để đếm số từ
                int charCount = content.Length;
                tbx_CountWord.Text = wordCount.ToString();
                tbx_CountCharacter.Text = charCount.ToString();
                streamReader.Close();
            }
            else // Khi lỗi
            {
                MessageBox.Show("Lỗi khi không chọn file, vui lòng đưa đúng file .txt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
