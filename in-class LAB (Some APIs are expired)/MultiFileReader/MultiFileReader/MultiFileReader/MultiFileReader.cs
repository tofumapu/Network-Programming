using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFileReader
{
    public partial class MultiFileReader : Form
    {
        public MultiFileReader()
        {
            InitializeComponent();
        }


        private void btn_Choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = true;
            openFile.Filter = "Text Files|*.txt;*.docx;*.doc |Code Files|*.cpp; *.html; *.c; *.cs; *.py; *.h; |All Files|*.*";
            rtbx_Output.Clear();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string[] files = openFile.FileNames;
                foreach (string file in files)
                {
                    int lineCount = 0;
                    //string[] lines = System.IO.File.ReadAllLines(file);
                    //foreach (string line in lines)
                    //{
                    //    lineCount++;
                    //}
                    try
                    {
                        using (StreamReader reader = new StreamReader(file))
                        {
                            while (reader.ReadLine() != null)
                            {
                                lineCount++;
                            }
                        }
                        if(lineCount <= 1)
                        {
                            rtbx_Output.Text += file + " has " + lineCount + " line\n";
                        }
                        else
                        rtbx_Output.Text += file + " has " + lineCount + " lines\n";
                    }
                    catch (Exception ex)
                    {
                        rtbx_Output.Text += file + " could not be read\n"; // không thể đọc
                    }
                }
            }
        }
    }
}
