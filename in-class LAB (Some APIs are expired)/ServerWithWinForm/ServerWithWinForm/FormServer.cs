using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerWithWinForm
{
    public partial class FormServer : Form
    {
        public static FormServer Instance { get; private set; }

        public FormServer()
        {
            InitializeComponent();

            Instance = this;
            // Initialize other components
        }

        public RichTextBox ServerRichTextBox
        {
            get { return rtb_Server; }
        }

        public RichTextBox GetRichTextBox()
        {
            if (rtb_Server == null || rtb_Server.IsDisposed)
            {
                throw new ObjectDisposedException("rtb_Server", "Cannot access a disposed object.");
            }
            return rtb_Server;
        }
    }
}
