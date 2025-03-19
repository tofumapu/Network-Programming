using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class LAB3_BaiTap4 : Form
    {
        public LAB3_BaiTap4()
        {
            InitializeComponent();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            LAB3_BaiTap4_Client client = new LAB3_BaiTap4_Client();
            client.Show();
        }

        private void buttonSever_Click(object sender, EventArgs e)
        {
            LAB3_BaiTap4_Server server = new LAB3_BaiTap4_Server();
            server.Show();
        }
    }
}
