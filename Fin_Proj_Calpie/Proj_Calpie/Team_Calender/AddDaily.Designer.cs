namespace Proj_Calpie
{
    partial class AddDaily
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDaily));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start_Minute = new System.Windows.Forms.ComboBox();
            this.Start_Hour = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorType = new System.Windows.Forms.ComboBox();
            this.MemoBox = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.NObutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.End_Hour = new System.Windows.Forms.ComboBox();
            this.End_Minute = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EndMonth = new System.Windows.Forms.ComboBox();
            this.StartMonth = new System.Windows.Forms.ComboBox();
            this.StartDay = new System.Windows.Forms.ComboBox();
            this.EndDay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "시작 시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "색깔";
            // 
            // Start_Minute
            // 
            this.Start_Minute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.Start_Minute.Location = new System.Drawing.Point(317, 9);
            this.Start_Minute.Name = "Start_Minute";
            this.Start_Minute.Size = new System.Drawing.Size(65, 23);
            this.Start_Minute.TabIndex = 27;
            // 
            // Start_Hour
            // 
            this.Start_Hour.FormattingEnabled = true;
            this.Start_Hour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.Start_Hour.Location = new System.Drawing.Point(232, 9);
            this.Start_Hour.Name = "Start_Hour";
            this.Start_Hour.Size = new System.Drawing.Size(66, 23);
            this.Start_Hour.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(301, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // ColorType
            // 
            this.ColorType.FormattingEnabled = true;
            this.ColorType.Items.AddRange(new object[] {
            "빨간색",
            "주황색",
            "노란색",
            "초록색",
            "파란색",
            "남색",
            "보라색",
            "흰색"});
            this.ColorType.Location = new System.Drawing.Point(78, 78);
            this.ColorType.Name = "ColorType";
            this.ColorType.Size = new System.Drawing.Size(75, 23);
            this.ColorType.TabIndex = 5;
            // 
            // MemoBox
            // 
            this.MemoBox.Location = new System.Drawing.Point(78, 106);
            this.MemoBox.Multiline = true;
            this.MemoBox.Name = "MemoBox";
            this.MemoBox.Size = new System.Drawing.Size(290, 41);
            this.MemoBox.TabIndex = 6;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(126, 153);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(61, 24);
            this.OKbutton.TabIndex = 7;
            this.OKbutton.Text = "적용";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // NObutton
            // 
            this.NObutton.Location = new System.Drawing.Point(204, 153);
            this.NObutton.Name = "NObutton";
            this.NObutton.Size = new System.Drawing.Size(61, 24);
            this.NObutton.TabIndex = 8;
            this.NObutton.Text = "취소";
            this.NObutton.UseVisualStyleBackColor = true;
            this.NObutton.Click += new System.EventHandler(this.NObutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "일정";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(301, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = ":";
            // 
            // End_Hour
            // 
            this.End_Hour.FormattingEnabled = true;
            this.End_Hour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.End_Hour.Location = new System.Drawing.Point(232, 40);
            this.End_Hour.Name = "End_Hour";
            this.End_Hour.Size = new System.Drawing.Size(66, 23);
            this.End_Hour.TabIndex = 12;
            // 
            // End_Minute
            // 
            this.End_Minute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.End_Minute.Location = new System.Drawing.Point(317, 41);
            this.End_Minute.Name = "End_Minute";
            this.End_Minute.Size = new System.Drawing.Size(65, 23);
            this.End_Minute.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(1, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "끝나는 시간";
            // 
            // EndMonth
            // 
            this.EndMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.EndMonth.Location = new System.Drawing.Point(82, 40);
            this.EndMonth.Name = "EndMonth";
            this.EndMonth.Size = new System.Drawing.Size(53, 23);
            this.EndMonth.TabIndex = 23;
            this.EndMonth.SelectedIndexChanged += new System.EventHandler(this.EndMonth_SelectedIndexChanged);
            // 
            // StartMonth
            // 
            this.StartMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.StartMonth.Location = new System.Drawing.Point(82, 9);
            this.StartMonth.Name = "StartMonth";
            this.StartMonth.Size = new System.Drawing.Size(53, 23);
            this.StartMonth.TabIndex = 25;
            this.StartMonth.SelectedIndexChanged += new System.EventHandler(this.StartMonth_SelectedIndexChanged);
            // 
            // StartDay
            // 
            this.StartDay.Location = new System.Drawing.Point(157, 9);
            this.StartDay.Name = "StartDay";
            this.StartDay.Size = new System.Drawing.Size(56, 23);
            this.StartDay.TabIndex = 24;
            // 
            // EndDay
            // 
            this.EndDay.Location = new System.Drawing.Point(157, 40);
            this.EndDay.Name = "EndDay";
            this.EndDay.Size = new System.Drawing.Size(56, 23);
            this.EndDay.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(136, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "월";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(136, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "월";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(213, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "일";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(213, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "일";
            // 
            // AddDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(394, 182);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EndDay);
            this.Controls.Add(this.EndMonth);
            this.Controls.Add(this.StartDay);
            this.Controls.Add(this.StartMonth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.End_Hour);
            this.Controls.Add(this.End_Minute);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NObutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.MemoBox);
            this.Controls.Add(this.ColorType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Start_Hour);
            this.Controls.Add(this.Start_Minute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDaily";
            this.Text = "AddDaily";
            this.Load += new System.EventHandler(this.AddDaily_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Start_Minute;
        private System.Windows.Forms.ComboBox Start_Hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ColorType;
        private System.Windows.Forms.TextBox MemoBox;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button NObutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox End_Hour;
        private System.Windows.Forms.ComboBox End_Minute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EndMonth;
        private System.Windows.Forms.ComboBox StartMonth;
        private System.Windows.Forms.ComboBox StartDay;
        private System.Windows.Forms.ComboBox EndDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}