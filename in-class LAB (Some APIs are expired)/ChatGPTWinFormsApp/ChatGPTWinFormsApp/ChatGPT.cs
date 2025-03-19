using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ChatGPTWinFormsApp
{
    public partial class ChatGPT : Form
    {
        private readonly ChatGPTService chatGPTService;

        public ChatGPT()
        {
            InitializeComponent();
            string apiKey = "AIzaSyCtWdMdhKFfA3DIJcpvxLVoIMe9cToYZ_I";
            chatGPTService = new ChatGPTService(apiKey);
        }

        private async void btn_send_Click(object sender, EventArgs e)
        {
            var message = "Hello, how can I help you?";
            var response = await chatGPTService.SendMessageAsync(message);

            if (response != null)
            {
                // Handle the response here (display on the interface, etc.)
                MessageBox.Show(JsonConvert.SerializeObject(response, Formatting.Indented));
            }
        }
    }
}
