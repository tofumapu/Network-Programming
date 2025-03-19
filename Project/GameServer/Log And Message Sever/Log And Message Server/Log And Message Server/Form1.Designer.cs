namespace Log_And_Message_Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            connect_lbx = new ListBox();
            groupBox2 = new GroupBox();
            message_lbx = new ListBox();
            Room = new GroupBox();
            room_lbx = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            Room.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(connect_lbx);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 290);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connection Manager";
            // 
            // connect_lbx
            // 
            connect_lbx.Font = new Font("Segoe UI", 12F);
            connect_lbx.FormattingEnabled = true;
            connect_lbx.HorizontalScrollbar = true;
            connect_lbx.ItemHeight = 28;
            connect_lbx.Location = new Point(6, 26);
            connect_lbx.Name = "connect_lbx";
            connect_lbx.ScrollAlwaysVisible = true;
            connect_lbx.Size = new Size(491, 228);
            connect_lbx.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(message_lbx);
            groupBox2.Location = new Point(12, 299);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(503, 299);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Message Manager";
            // 
            // message_lbx
            // 
            message_lbx.Font = new Font("Segoe UI", 12F);
            message_lbx.FormattingEnabled = true;
            message_lbx.ItemHeight = 28;
            message_lbx.Location = new Point(5, 32);
            message_lbx.Name = "message_lbx";
            message_lbx.ScrollAlwaysVisible = true;
            message_lbx.Size = new Size(492, 228);
            message_lbx.TabIndex = 0;
            // 
            // Room
            // 
            Room.Controls.Add(room_lbx);
            Room.Location = new Point(521, 12);
            Room.Name = "Room";
            Room.Size = new Size(497, 586);
            Room.TabIndex = 2;
            Room.TabStop = false;
            Room.Text = "Room Manager";
            // 
            // room_lbx
            // 
            room_lbx.Font = new Font("Segoe UI", 12F);
            room_lbx.FormattingEnabled = true;
            room_lbx.ItemHeight = 28;
            room_lbx.Location = new Point(11, 28);
            room_lbx.Name = "room_lbx";
            room_lbx.ScrollAlwaysVisible = true;
            room_lbx.Size = new Size(480, 536);
            room_lbx.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 625);
            Controls.Add(Room);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "LOG AND MESSAGE SERVER";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            Room.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtMessage;
        private GroupBox Room;
        private ListBox connect_lbx;
        private ListBox message_lbx;
        private ListBox room_lbx;
    }
}
