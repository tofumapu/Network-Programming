namespace Lab1_23520231_23520249
{
    partial class Lab1_BaiTap5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1_BaiTap5));
            lbl_Title = new Label();
            lbl_List = new Label();
            btn_Excute = new Button();
            gb_OutputList = new GroupBox();
            tbx_Input = new TextBox();
            lbl_DTB = new Label();
            lbl_Max = new Label();
            lbl_CountPass = new Label();
            lbl_Classify = new Label();
            lbl_Min = new Label();
            lbl_CountFail = new Label();
            lbl_OutputDTB = new Label();
            lbl_OutputMax = new Label();
            lbl_OutputCountPass = new Label();
            lbl_OutputClassify = new Label();
            lbl_OutputMin = new Label();
            lbl_OutputCountFail = new Label();
            btn_Retype = new Button();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(230, 61);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(610, 68);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "Phần mềm quản lý điểm";
            // 
            // lbl_List
            // 
            lbl_List.AutoSize = true;
            lbl_List.Location = new Point(165, 189);
            lbl_List.Name = "lbl_List";
            lbl_List.Size = new Size(191, 32);
            lbl_List.TabIndex = 1;
            lbl_List.Text = "Danh sách điểm:";
            // 
            // btn_Excute
            // 
            btn_Excute.Location = new Point(821, 329);
            btn_Excute.Name = "btn_Excute";
            btn_Excute.Size = new Size(142, 41);
            btn_Excute.TabIndex = 3;
            btn_Excute.Text = "Xuất";
            btn_Excute.UseVisualStyleBackColor = true;
            btn_Excute.Click += btn_Excute_Click;
            // 
            // gb_OutputList
            // 
            gb_OutputList.Location = new Point(167, 404);
            gb_OutputList.Name = "gb_OutputList";
            gb_OutputList.Size = new Size(796, 384);
            gb_OutputList.TabIndex = 4;
            gb_OutputList.TabStop = false;
            gb_OutputList.Text = "Danh sách môn học và điểm";
            // 
            // tbx_Input
            // 
            tbx_Input.Location = new Point(355, 186);
            tbx_Input.Multiline = true;
            tbx_Input.Name = "tbx_Input";
            tbx_Input.Size = new Size(607, 103);
            tbx_Input.TabIndex = 5;
            // 
            // lbl_DTB
            // 
            lbl_DTB.AutoSize = true;
            lbl_DTB.Location = new Point(165, 849);
            lbl_DTB.Name = "lbl_DTB";
            lbl_DTB.Size = new Size(196, 32);
            lbl_DTB.TabIndex = 6;
            lbl_DTB.Text = "Điểm trung bình:";
            // 
            // lbl_Max
            // 
            lbl_Max.AutoSize = true;
            lbl_Max.Location = new Point(167, 917);
            lbl_Max.Name = "lbl_Max";
            lbl_Max.Size = new Size(261, 32);
            lbl_Max.TabIndex = 7;
            lbl_Max.Text = "Môn có điểm cao nhất:";
            // 
            // lbl_CountPass
            // 
            lbl_CountPass.AutoSize = true;
            lbl_CountPass.Location = new Point(167, 984);
            lbl_CountPass.Name = "lbl_CountPass";
            lbl_CountPass.Size = new Size(149, 32);
            lbl_CountPass.TabIndex = 8;
            lbl_CountPass.Text = "Số môn đậu:";
            // 
            // lbl_Classify
            // 
            lbl_Classify.AutoSize = true;
            lbl_Classify.Location = new Point(620, 852);
            lbl_Classify.Name = "lbl_Classify";
            lbl_Classify.Size = new Size(189, 32);
            lbl_Classify.TabIndex = 9;
            lbl_Classify.Text = "Xếp loại học lực:";
            // 
            // lbl_Min
            // 
            lbl_Min.AutoSize = true;
            lbl_Min.Location = new Point(620, 917);
            lbl_Min.Name = "lbl_Min";
            lbl_Min.Size = new Size(272, 32);
            lbl_Min.TabIndex = 10;
            lbl_Min.Text = "Môn có điểm thấp nhất:";
            // 
            // lbl_CountFail
            // 
            lbl_CountFail.AutoSize = true;
            lbl_CountFail.Location = new Point(620, 984);
            lbl_CountFail.Name = "lbl_CountFail";
            lbl_CountFail.Size = new Size(224, 32);
            lbl_CountFail.TabIndex = 11;
            lbl_CountFail.Text = "Số môn không đậu:";
            // 
            // lbl_OutputDTB
            // 
            lbl_OutputDTB.AutoSize = true;
            lbl_OutputDTB.Location = new Point(355, 849);
            lbl_OutputDTB.Name = "lbl_OutputDTB";
            lbl_OutputDTB.Size = new Size(0, 32);
            lbl_OutputDTB.TabIndex = 12;
            // 
            // lbl_OutputMax
            // 
            lbl_OutputMax.AutoSize = true;
            lbl_OutputMax.Location = new Point(420, 917);
            lbl_OutputMax.Name = "lbl_OutputMax";
            lbl_OutputMax.Size = new Size(0, 32);
            lbl_OutputMax.TabIndex = 13;
            // 
            // lbl_OutputCountPass
            // 
            lbl_OutputCountPass.AutoSize = true;
            lbl_OutputCountPass.Location = new Point(314, 984);
            lbl_OutputCountPass.Name = "lbl_OutputCountPass";
            lbl_OutputCountPass.Size = new Size(0, 32);
            lbl_OutputCountPass.TabIndex = 14;
            // 
            // lbl_OutputClassify
            // 
            lbl_OutputClassify.AutoSize = true;
            lbl_OutputClassify.Location = new Point(805, 852);
            lbl_OutputClassify.Name = "lbl_OutputClassify";
            lbl_OutputClassify.Size = new Size(0, 32);
            lbl_OutputClassify.TabIndex = 15;
            // 
            // lbl_OutputMin
            // 
            lbl_OutputMin.AutoSize = true;
            lbl_OutputMin.Location = new Point(878, 917);
            lbl_OutputMin.Name = "lbl_OutputMin";
            lbl_OutputMin.Size = new Size(0, 32);
            lbl_OutputMin.TabIndex = 16;
            // 
            // lbl_OutputCountFail
            // 
            lbl_OutputCountFail.AutoSize = true;
            lbl_OutputCountFail.Location = new Point(836, 984);
            lbl_OutputCountFail.Name = "lbl_OutputCountFail";
            lbl_OutputCountFail.Size = new Size(0, 32);
            lbl_OutputCountFail.TabIndex = 17;
            // 
            // btn_Retype
            // 
            btn_Retype.Location = new Point(663, 329);
            btn_Retype.Name = "btn_Retype";
            btn_Retype.Size = new Size(142, 41);
            btn_Retype.TabIndex = 18;
            btn_Retype.Text = "Nhập lại";
            btn_Retype.UseVisualStyleBackColor = true;
            btn_Retype.Click += btn_Retype_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(509, 329);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(142, 41);
            btn_Exit.TabIndex = 19;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Lab1_BaiTap5
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 1050);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Retype);
            Controls.Add(lbl_OutputCountFail);
            Controls.Add(lbl_OutputMin);
            Controls.Add(lbl_OutputClassify);
            Controls.Add(lbl_OutputCountPass);
            Controls.Add(lbl_OutputMax);
            Controls.Add(lbl_OutputDTB);
            Controls.Add(lbl_CountFail);
            Controls.Add(lbl_Min);
            Controls.Add(lbl_Classify);
            Controls.Add(lbl_CountPass);
            Controls.Add(lbl_Max);
            Controls.Add(lbl_DTB);
            Controls.Add(tbx_Input);
            Controls.Add(gb_OutputList);
            Controls.Add(btn_Excute);
            Controls.Add(lbl_List);
            Controls.Add(lbl_Title);
            Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Lab1_BaiTap5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LAB1_BaiTap5";
            Load += LAB1_BaiTap5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void LAB1_BaiTap5_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private Label lbl_Title;
        private Label lbl_List;
        private Button btn_Excute;
        private GroupBox gb_OutputList;
        private TextBox tbx_Input;
        private Label lbl_DTB;
        private Label lbl_Max;
        private Label lbl_CountPass;
        private Label lbl_Classify;
        private Label lbl_Min;
        private Label lbl_CountFail;
        private Label lbl_OutputDTB;
        private Label lbl_OutputMax;
        private Label lbl_OutputCountPass;
        private Label lbl_OutputClassify;
        private Label lbl_OutputMin;
        private Label lbl_OutputCountFail;
        private Button btn_Retype;
        private Button btn_Exit;
    }
}