namespace LAB3
{
    partial class LAB3_BaiTap3_Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            btn_Listen = new Button();
            btn_Exit = new Button();
            tb_ip = new TextBox();
            tb_Port = new TextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(38, 137);
            listView1.Margin = new Padding(4, 6, 4, 6);
            listView1.Name = "listView1";
            listView1.Size = new Size(862, 582);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // btn_Listen
            // 
            btn_Listen.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Listen.Location = new Point(748, 45);
            btn_Listen.Margin = new Padding(4, 6, 4, 6);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(152, 56);
            btn_Listen.TabIndex = 1;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(553, 45);
            btn_Exit.Margin = new Padding(4, 6, 4, 6);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(152, 56);
            btn_Exit.TabIndex = 1;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // tb_ip
            // 
            tb_ip.Location = new Point(38, 56);
            tb_ip.Name = "tb_ip";
            tb_ip.Size = new Size(229, 35);
            tb_ip.TabIndex = 2;
            // 
            // tb_Port
            // 
            tb_Port.Location = new Point(302, 56);
            tb_Port.Name = "tb_Port";
            tb_Port.Size = new Size(214, 35);
            tb_Port.TabIndex = 3;
            // 
            // LAB3_BaiTap3_Server
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 748);
            Controls.Add(tb_Port);
            Controls.Add(tb_ip);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Listen);
            Controls.Add(listView1);
            Margin = new Padding(4, 6, 4, 6);
            Name = "LAB3_BaiTap3_Server";
            Text = "Bai3_Server";
            FormClosed += Bai3_Server_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.Button btn_Exit;
        private TextBox tb_ip;
        private TextBox tb_Port;
    }
}