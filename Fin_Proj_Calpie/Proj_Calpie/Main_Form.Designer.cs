namespace Proj_Calpie
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.Saturday = new System.Windows.Forms.Label();
            this.Friday = new System.Windows.Forms.Label();
            this.Thursday = new System.Windows.Forms.Label();
            this.Wednesday = new System.Windows.Forms.Label();
            this.Tuesday = new System.Windows.Forms.Label();
            this.Monday = new System.Windows.Forms.Label();
            this.Sunday = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.Monthly_Acc = new System.Windows.Forms.ListBox();
            this.Monthly_listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.DayContainer);
            this.splitContainer1.Panel1.Controls.Add(this.Saturday);
            this.splitContainer1.Panel1.Controls.Add(this.Friday);
            this.splitContainer1.Panel1.Controls.Add(this.Thursday);
            this.splitContainer1.Panel1.Controls.Add(this.Wednesday);
            this.splitContainer1.Panel1.Controls.Add(this.Tuesday);
            this.splitContainer1.Panel1.Controls.Add(this.Monday);
            this.splitContainer1.Panel1.Controls.Add(this.Sunday);
            this.splitContainer1.Panel1.Controls.Add(this.Next);
            this.splitContainer1.Panel1.Controls.Add(this.Prev);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Monthly_Acc);
            this.splitContainer1.Panel2.Controls.Add(this.Monthly_listBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(984, 641);
            this.splitContainer1.SplitterDistance = 640;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(273, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 40);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DayContainer
            // 
            this.DayContainer.Location = new System.Drawing.Point(0, 100);
            this.DayContainer.Name = "DayContainer";
            this.DayContainer.Size = new System.Drawing.Size(640, 540);
            this.DayContainer.TabIndex = 16;
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Saturday.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Saturday.Location = new System.Drawing.Point(557, 54);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(69, 43);
            this.Saturday.TabIndex = 15;
            this.Saturday.Text = "SAT";
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Friday.Location = new System.Drawing.Point(479, 54);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(58, 43);
            this.Friday.TabIndex = 14;
            this.Friday.Text = "FRI";
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Thursday.Location = new System.Drawing.Point(387, 54);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(71, 43);
            this.Thursday.TabIndex = 13;
            this.Thursday.Text = "THR";
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Wednesday.Location = new System.Drawing.Point(286, 53);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(78, 43);
            this.Wednesday.TabIndex = 12;
            this.Wednesday.Text = "WED";
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tuesday.Location = new System.Drawing.Point(197, 54);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(70, 43);
            this.Tuesday.TabIndex = 11;
            this.Tuesday.Text = "TUE";
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Monday.Location = new System.Drawing.Point(100, 53);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(80, 43);
            this.Monday.TabIndex = 10;
            this.Monday.Text = "MON";
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sunday.ForeColor = System.Drawing.Color.Red;
            this.Sunday.Location = new System.Drawing.Point(12, 54);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(72, 43);
            this.Sunday.TabIndex = 9;
            this.Sunday.Text = "SUN";
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Next.Location = new System.Drawing.Point(370, 7);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(46, 43);
            this.Next.TabIndex = 8;
            this.Next.Text = "▶";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Prev
            // 
            this.Prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Prev.Location = new System.Drawing.Point(221, 7);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(46, 43);
            this.Prev.TabIndex = 7;
            this.Prev.Text = "◀";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Monthly_Acc
            // 
            this.Monthly_Acc.FormattingEnabled = true;
            this.Monthly_Acc.ItemHeight = 16;
            this.Monthly_Acc.Location = new System.Drawing.Point(12, 353);
            this.Monthly_Acc.Name = "Monthly_Acc";
            this.Monthly_Acc.Size = new System.Drawing.Size(316, 276);
            this.Monthly_Acc.TabIndex = 4;
            // 
            // Monthly_listBox1
            // 
            this.Monthly_listBox1.FormattingEnabled = true;
            this.Monthly_listBox1.ItemHeight = 16;
            this.Monthly_listBox1.Location = new System.Drawing.Point(12, 70);
            this.Monthly_listBox1.Name = "Monthly_listBox1";
            this.Monthly_listBox1.Size = new System.Drawing.Size(316, 228);
            this.Monthly_listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(77, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monthly Account Book";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monthly Schedule";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 641);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "달력";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Saturday;
        private System.Windows.Forms.Label Friday;
        private System.Windows.Forms.Label Thursday;
        private System.Windows.Forms.Label Wednesday;
        private System.Windows.Forms.Label Tuesday;
        private System.Windows.Forms.Label Monday;
        private System.Windows.Forms.Label Sunday;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel DayContainer;
        private System.Windows.Forms.ListBox Monthly_listBox1;
        private System.Windows.Forms.ListBox Monthly_Acc;
    }
}