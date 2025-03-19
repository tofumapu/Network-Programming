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
    public partial class Lab2_BaiTap5 : Form
    {
        public Lab2_BaiTap5()
        {
            InitializeComponent();
        }
        private void bt_Tim_Click(object sender, EventArgs e)
        {
            string folderPath = tbx_Path.Text;  // Lấy đường dẫn folder ở textbox
            if (Directory.Exists(folderPath))
            {
                listView_Show.Items.Clear(); // Clear listView
                string[] files = Directory.GetFiles(folderPath);
                string[] directories = Directory.GetDirectories(folderPath);

                foreach (string dir in directories) // Hiển thị thư mục
                {
                    DirectoryInfo di = new DirectoryInfo(dir);
                    ListViewItem item = new ListViewItem(RemoveExtension(di.Name));
                    listView_Show.Items.Add(item);
                    listView_Show.SmallImageList = imageList;
                    listView_Show.LargeImageList = imageList; // Sử dụng imageList để hiển thị icon
                    item.ImageIndex = 10; // Chỉ số icon cho thư mục
                    item.SubItems.Add(di.CreationTime.ToString());
                    item.SubItems.Add("File Folder");
                    item.SubItems.Add("");
                }

                foreach (string file in files) // Hiển thị file
                {
                    FileInfo fi = new FileInfo(file);
                    ListViewItem item = new ListViewItem(RemoveExtension(fi.Name));
                    listView_Show.Items.Add(item);
                    listView_Show.SmallImageList = imageList;
                    listView_Show.LargeImageList = imageList; // Sử dụng imageList để hiển thị icon
                    item.ImageIndex = GetIconIndex(fi.Name); // Chỉ số icon cho file
                    item.SubItems.Add(fi.CreationTime.ToString());
                    item.SubItems.Add(GetFileType(fi.Name));
                    item.SubItems.Add(FormatFileSize(fi.Length));
                }

            }
            else
            {
                MessageBox.Show("Đường dẫn không tồn tại!"); // Cảnh báo khi đường dẫn không hợp lệ
            }
        }

        //ẩn form 
        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Tìm folder bằng giao diện Windows 
        private void bt_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            try
            {
                listView_Show.Items.Clear();
                tbx_Path.Text = fbd.SelectedPath;   //đổi đường dẫn của textbox thành đường dẫn của thư mục được chọn
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                string[] directories = Directory.GetDirectories(fbd.SelectedPath);
                foreach (string dir in directories) // Hiển thị thư mục
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(dir);
                    ListViewItem item = new ListViewItem(directoryInfo.Name);
                    listView_Show.Items.Add(item);
                    listView_Show.SmallImageList = imageList;
                    listView_Show.LargeImageList = imageList; // Sử dụng imageList để hiển thị icon
                    item.ImageIndex = 10; // Chỉ số của icon thư mục
                    item.SubItems.Add(directoryInfo.CreationTime.ToString());
                    item.SubItems.Add("File Folder"); // Loại file
                    item.SubItems.Add(""); // Không có phần mở rộng
                    item.SubItems.Add(""); // Không có dung lượng

                }

                foreach (string file in files) // Hiển thị file
                {
                    FileInfo fi = new FileInfo(file);
                    ListViewItem item = new ListViewItem(RemoveExtension(fi.Name));
                    listView_Show.Items.Add(item);
                    listView_Show.SmallImageList = imageList;
                    listView_Show.LargeImageList = imageList; // Sử dụng imageList để hiển thị icon
                    item.ImageIndex = GetIconIndex(fi.Name); // Chỉ số của icon file
                    item.SubItems.Add(fi.CreationTime.ToString());
                    item.SubItems.Add(GetFileType(fi.Name)); // Loại file
                    item.SubItems.Add(FormatFileSize(fi.Length).ToString());
                }
            }

            catch (Exception tmp)
            {
                MessageBox.Show("Bạn chưa chọn folder!\n Caution: " + tmp.Message);
            }
        }


        private int GetIconIndex(string fileName)
        {
            string extensionFile = Path.GetExtension(fileName);
            switch (extensionFile)
            {
                case ".exe":
                    return 1;
                case ".pdf":
                    return 2;
                case ".html":
                case ".htm":
                case ".css":
                    return 3;
                case ".cs":
                case ".java":
                case ".py":
                case ".rb":
                case ".sql":
                case ".c":
                case ".asm":
                case ".php":
                case ".js":
                    return 4;
                case ".ppt":
                case ".pptx":
                    return 5;
                case ".doc":
                case ".docx":
                    return 6;
                case ".xls":
                case ".xlsx":
                    return 7;
                case ".cpp":
                    return 8;
                case ".jpg":
                case ".jpeg":
                case ".png":
                case ".gif":
                case ".bmp":
                case ".ico":
                case ".svg":
                case ".tiff":
                case ".webp":
                    return 9;
                default:
                    return 0;
            }
        }

        private string RemoveExtension(string fileName)
        {
            return Path.GetFileNameWithoutExtension(fileName); // Phương thức này sẽ trả về tên file không kèm theo phần mở rộng
        }

        private string FormatFileSize(long size) // KB, MB, GB, TB
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB" };
            int suffixIndex = 0;
            while (size > 1024)
            {
                size /= 1024;
                suffixIndex++;
            }
            return size + " " + suffixes[suffixIndex];
        }

        private string GetFileType(string fileName)
        {
            string extensionFile = Path.GetExtension(fileName);
            switch (extensionFile)
            {
                case ".txt":
                    return "Text Document";
                case ".rtf":
                    return "Rich Text Document";
                case ".doc":
                case ".docx":
                    return "Microsoft Word Document";
                case ".pdf":
                    return "PDF Document";
                case ".xls":
                case ".xlsx":
                    return "Microsoft Excel Document";
                case ".ppt":
                case ".pptx":
                    return "Microsoft PowerPoint Document";
                case ".jpg":
                    return "JPG File";
                case ".jpeg":
                    return "JPEG File";
                case ".png":
                    return "PNG File";
                case ".gif":
                    return "GIF File";
                case ".bmp":
                    return "BMP File";
                case ".ico":
                    return "Icon File";
                case ".svg":
                    return "SVG File";
                case ".mp3":
                    return "MP3 File";
                case ".ogg":
                    return "OGG File";
                case ".wav":
                    return "WAV File";
                case ".flac":
                    return "FLAC File";
                case ".m4a":
                    return "M4A File";
                case ".wma":
                    return "WMA File";
                case ".aac":
                    return "AAC File";
                case ".mp4":
                    return "MP4 File";
                case ".mkv":
                    return "MKV File";
                case ".flv":
                    return "FLV File";
                case ".mov":
                    return "MOV File";
                case ".wmv":
                    return "WMV File";
                case ".mpg":
                    return "MPG File";
                case ".avi":
                    return "AVI File";
                case ".cpp":
                    return "C++ Source File";
                case ".cs":
                    return "C# Source File";
                case ".html":
                case ".htm":
                    return "HTML Document";
                case ".css":
                    return "CSS Document";
                case ".js":
                    return "JavaScript Document";
                case ".php":
                    return "PHP Document";
                case ".py":
                    return "Python Source File";
                case ".rb":
                    return "Ruby Source File";
                case ".sql":
                    return "SQL Document";
                case ".xml":
                    return "XML Document";
                case ".zip":
                case ".rar":
                case ".7z":
                    return "Compressed File";
                case ".exe":
                case ".msi":
                    return "Application";
                case ".dll":
                    return "Dynamic Link Library";
                case ".iso":
                    return "ISO Image";
                case ".bak":
                    return "Backup File";
                case ".tmp":
                    return "Temporary File";
                case ".log":
                    return "Log File";
                case ".ini":
                    return "Configuration File";
                case ".bat":
                    return "Batch File";
                case ".cmd":
                    return "Command Prompt Script";
                case ".sh":
                    return "Shell Script";
                case ".ps1":
                    return "PowerShell Script";
                case ".jar":
                    return "Java Archive";
                case ".war":
                    return "Web Archive";
                case ".ear":
                    return "Enterprise Archive";
                case ".class":
                    return "Java Class File";
                case ".obj":
                    return "Object File";
                case ".lib":
                    return "Library File";
                case ".h":
                    return "Header File";
                case ".c":
                    return "C Source File";
                case ".asm":
                    return "Assembly Source File";
                case ".sln":
                    return "Solution File";
                case ".csproj":
                    return "C# Project File";
                case ".vcxproj":
                    return "Visual C++ Project File";
                case ".java":
                    return "Java Project File";
                case ".pyproj":
                    return "Python Project File";
                case ".suo":
                    return "Solution User Options File";
                case ".user":
                    return "User Options File";
                case ".vspscc":
                    return "Visual Studio Project Source Control File";
                case ".vssscc":
                    return "Visual Studio Solution Source Control File";
                case ".pdb":
                    return "Program Database";
                default:
                    return "File";
            }
        }
    }
}
