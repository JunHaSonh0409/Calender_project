namespace Proj_Calpie
{
    partial class Add_Delete_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Delete_Form));
            this.Schedue_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.She_Del = new System.Windows.Forms.Button();
            this.Sche_Add = new System.Windows.Forms.Button();
            this.Schedule_list = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Account_Panel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.expend = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.income = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Account_Del = new System.Windows.Forms.Button();
            this.Account_Add = new System.Windows.Forms.Button();
            this.Account_list = new System.Windows.Forms.ListBox();
            this.Memo_Panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Memo_Del = new System.Windows.Forms.Button();
            this.Memo_Add = new System.Windows.Forms.Button();
            this.Memo_TB = new System.Windows.Forms.TextBox();
            this.Schedue_Panel.SuspendLayout();
            this.Account_Panel.SuspendLayout();
            this.Memo_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Schedue_Panel
            // 
            this.Schedue_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Schedue_Panel.Controls.Add(this.label1);
            this.Schedue_Panel.Controls.Add(this.She_Del);
            this.Schedue_Panel.Controls.Add(this.Sche_Add);
            this.Schedue_Panel.Controls.Add(this.Schedule_list);
            this.Schedue_Panel.Controls.Add(this.panel2);
            this.Schedue_Panel.Location = new System.Drawing.Point(3, 0);
            this.Schedue_Panel.Name = "Schedue_Panel";
            this.Schedue_Panel.Size = new System.Drawing.Size(170, 550);
            this.Schedue_Panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(52, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "일정";
            // 
            // She_Del
            // 
            this.She_Del.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.She_Del.Location = new System.Drawing.Point(87, 487);
            this.She_Del.Name = "She_Del";
            this.She_Del.Size = new System.Drawing.Size(80, 60);
            this.She_Del.TabIndex = 2;
            this.She_Del.Text = "삭제";
            this.She_Del.UseVisualStyleBackColor = true;
            this.She_Del.Click += new System.EventHandler(this.She_Del_Click);
            // 
            // Sche_Add
            // 
            this.Sche_Add.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sche_Add.Location = new System.Drawing.Point(3, 487);
            this.Sche_Add.Name = "Sche_Add";
            this.Sche_Add.Size = new System.Drawing.Size(80, 60);
            this.Sche_Add.TabIndex = 2;
            this.Sche_Add.Text = "추가";
            this.Sche_Add.UseVisualStyleBackColor = true;
            this.Sche_Add.Click += new System.EventHandler(this.Sche_Add_Click);
            // 
            // Schedule_list
            // 
            this.Schedule_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Schedule_list.FormattingEnabled = true;
            this.Schedule_list.ItemHeight = 15;
            this.Schedule_list.Items.AddRange(new object[] {
            "ㅇㅇㅇ",
            "-",
            "-",
            "-"});
            this.Schedule_list.Location = new System.Drawing.Point(25, 72);
            this.Schedule_list.Name = "Schedule_list";
            this.Schedule_list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Schedule_list.Size = new System.Drawing.Size(142, 409);
            this.Schedule_list.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(181, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 550);
            this.panel2.TabIndex = 0;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exit_btn.Location = new System.Drawing.Point(178, 553);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(160, 36);
            this.Exit_btn.TabIndex = 1;
            this.Exit_btn.Text = "돌아가기";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Account_Panel
            // 
            this.Account_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Account_Panel.Controls.Add(this.label11);
            this.Account_Panel.Controls.Add(this.label8);
            this.Account_Panel.Controls.Add(this.expend);
            this.Account_Panel.Controls.Add(this.label10);
            this.Account_Panel.Controls.Add(this.label7);
            this.Account_Panel.Controls.Add(this.income);
            this.Account_Panel.Controls.Add(this.label5);
            this.Account_Panel.Controls.Add(this.label2);
            this.Account_Panel.Controls.Add(this.Account_Del);
            this.Account_Panel.Controls.Add(this.Account_Add);
            this.Account_Panel.Controls.Add(this.Account_list);
            this.Account_Panel.Location = new System.Drawing.Point(178, 0);
            this.Account_Panel.Name = "Account_Panel";
            this.Account_Panel.Size = new System.Drawing.Size(170, 550);
            this.Account_Panel.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(5, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "수입/지출 내역";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(145, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "\\";
            // 
            // expend
            // 
            this.expend.AutoSize = true;
            this.expend.Location = new System.Drawing.Point(79, 454);
            this.expend.Name = "expend";
            this.expend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.expend.Size = new System.Drawing.Size(14, 15);
            this.expend.TabIndex = 8;
            this.expend.Text = "0";
            this.expend.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(8, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "오늘 지출";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(145, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "\\";
            // 
            // income
            // 
            this.income.AutoSize = true;
            this.income.Location = new System.Drawing.Point(79, 420);
            this.income.Name = "income";
            this.income.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.income.Size = new System.Drawing.Size(14, 15);
            this.income.TabIndex = 5;
            this.income.Text = "0";
            this.income.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "오늘 수입";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(38, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "가계부";
            // 
            // Account_Del
            // 
            this.Account_Del.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Account_Del.Location = new System.Drawing.Point(87, 487);
            this.Account_Del.Name = "Account_Del";
            this.Account_Del.Size = new System.Drawing.Size(80, 60);
            this.Account_Del.TabIndex = 2;
            this.Account_Del.Text = "삭제";
            this.Account_Del.UseVisualStyleBackColor = true;
            this.Account_Del.Click += new System.EventHandler(this.Account_Del_Click);
            // 
            // Account_Add
            // 
            this.Account_Add.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Account_Add.Location = new System.Drawing.Point(3, 487);
            this.Account_Add.Name = "Account_Add";
            this.Account_Add.Size = new System.Drawing.Size(80, 60);
            this.Account_Add.TabIndex = 2;
            this.Account_Add.Text = "추가";
            this.Account_Add.UseVisualStyleBackColor = true;
            this.Account_Add.Click += new System.EventHandler(this.Account_Add_Click);
            // 
            // Account_list
            // 
            this.Account_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Account_list.FormattingEnabled = true;
            this.Account_list.ItemHeight = 15;
            this.Account_list.Location = new System.Drawing.Point(0, 88);
            this.Account_list.Name = "Account_list";
            this.Account_list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Account_list.Size = new System.Drawing.Size(167, 319);
            this.Account_list.TabIndex = 1;
            // 
            // Memo_Panel
            // 
            this.Memo_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Memo_Panel.Controls.Add(this.Memo_TB);
            this.Memo_Panel.Controls.Add(this.label4);
            this.Memo_Panel.Controls.Add(this.Memo_Del);
            this.Memo_Panel.Controls.Add(this.Memo_Add);
            this.Memo_Panel.Location = new System.Drawing.Point(352, 0);
            this.Memo_Panel.Name = "Memo_Panel";
            this.Memo_Panel.Size = new System.Drawing.Size(170, 550);
            this.Memo_Panel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(52, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "메모";
            // 
            // Memo_Del
            // 
            this.Memo_Del.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Memo_Del.Location = new System.Drawing.Point(87, 487);
            this.Memo_Del.Name = "Memo_Del";
            this.Memo_Del.Size = new System.Drawing.Size(80, 60);
            this.Memo_Del.TabIndex = 2;
            this.Memo_Del.Text = "삭제";
            this.Memo_Del.UseVisualStyleBackColor = true;
            this.Memo_Del.Click += new System.EventHandler(this.Memo_Del_Click);
            // 
            // Memo_Add
            // 
            this.Memo_Add.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Memo_Add.Location = new System.Drawing.Point(3, 487);
            this.Memo_Add.Name = "Memo_Add";
            this.Memo_Add.Size = new System.Drawing.Size(80, 60);
            this.Memo_Add.TabIndex = 2;
            this.Memo_Add.Text = "추가";
            this.Memo_Add.UseVisualStyleBackColor = true;
            this.Memo_Add.Click += new System.EventHandler(this.Memo_Add_Click);
            // 
            // Memo_TB
            // 
            this.Memo_TB.Location = new System.Drawing.Point(3, 72);
            this.Memo_TB.Multiline = true;
            this.Memo_TB.Name = "Memo_TB";
            this.Memo_TB.Size = new System.Drawing.Size(164, 409);
            this.Memo_TB.TabIndex = 5;
            // 
            // Add_Delete_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 601);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Memo_Panel);
            this.Controls.Add(this.Account_Panel);
            this.Controls.Add(this.Schedue_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 640);
            this.Name = "Add_Delete_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Delete_Form";
            this.Load += new System.EventHandler(this.Add_Delete_Form_Load);
            this.Schedue_Panel.ResumeLayout(false);
            this.Schedue_Panel.PerformLayout();
            this.Account_Panel.ResumeLayout(false);
            this.Account_Panel.PerformLayout();
            this.Memo_Panel.ResumeLayout(false);
            this.Memo_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Schedue_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button She_Del;
        private System.Windows.Forms.Button Sche_Add;
        private System.Windows.Forms.ListBox Schedule_list;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Panel Account_Panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Account_Del;
        private System.Windows.Forms.Button Account_Add;
        private System.Windows.Forms.ListBox Account_list;
        private System.Windows.Forms.Panel Memo_Panel;
        private System.Windows.Forms.Button Memo_Del;
        private System.Windows.Forms.Button Memo_Add;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label expend;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label income;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Memo_TB;
    }
}