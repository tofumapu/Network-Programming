﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_23520231_23520249
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_BaiTap1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Server BaiTap1_Server = new Server();
                BaiTap1_Server.ShowDialog();
            });
            Task.Run(() =>
            {
                Client BaiTap1_Client = new Client();
                BaiTap1_Client.ShowDialog();
            });
        }

        //private void btn_BaiTap2_Click(object sender, EventArgs e)
        //{
        //    LAB3_BaiTap2 BaiTap2 = new LAB3_BaiTap2();
        //    BaiTap2.ShowDialog();
        //}
        //private void btn_BaiTap3_Click(object sender, EventArgs e)
        //{
        //    Task.Run(() =>
        //    {
        //        LAB3_BaiTap3_Client BaiTap3_Client = new LAB3_BaiTap3_Client();
        //        BaiTap3_Client.ShowDialog();
        //    });
        //    Task.Run(() =>
        //    {
        //        LAB3_BaiTap3_Server BaiTap3_Server = new LAB3_BaiTap3_Server();
        //        BaiTap3_Server.ShowDialog();
        //    });
        //}
        //private void btn_BaiTap4_Click(object sender, EventArgs e)
        //{
        //    LAB3_BaiTap4 BaiTap4 = new LAB3_BaiTap4();
        //    BaiTap4.Show();
        //}

        private void btn_BaiTap5_Click(object sender, EventArgs e)
        {
            //Lab2_BaiTap5 BaiTap5 = new Lab2_BaiTap5();
            //BaiTap5.ShowDialog();
        }
    }
}
