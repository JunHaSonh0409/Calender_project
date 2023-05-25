namespace Proj_Calpie
{
    partial class SubAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.SubAccountTitle = new System.Windows.Forms.TextBox();
            this.AditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SubAdit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "제목";
            // 
            // SubAccountTitle
            // 
            this.SubAccountTitle.Location = new System.Drawing.Point(82, 66);
            this.SubAccountTitle.Name = "SubAccountTitle";
            this.SubAccountTitle.Size = new System.Drawing.Size(227, 23);
            this.SubAccountTitle.TabIndex = 1;
            // 
            // AditButton
            // 
            this.AditButton.Location = new System.Drawing.Point(6, 113);
            this.AditButton.Name = "AditButton";
            this.AditButton.Size = new System.Drawing.Size(63, 23);
            this.AditButton.TabIndex = 2;
            this.AditButton.Text = "수정";
            this.AditButton.UseVisualStyleBackColor = true;
            this.AditButton.Click += new System.EventHandler(this.AditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(170, 113);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(63, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "삭제";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(248, 113);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(63, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "취소";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SubAdit
            // 
            this.SubAdit.FormattingEnabled = true;
            this.SubAdit.Items.AddRange(new object[] {
            "수정",
            "삭제"});
            this.SubAdit.Location = new System.Drawing.Point(82, 24);
            this.SubAdit.Name = "SubAdit";
            this.SubAdit.Size = new System.Drawing.Size(68, 23);
            this.SubAdit.TabIndex = 5;
            this.SubAdit.SelectedIndexChanged += new System.EventHandler(this.SubAdit_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "수정/삭제";
            // 
            // SubAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 147);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubAdit);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AditButton);
            this.Controls.Add(this.SubAccountTitle);
            this.Controls.Add(this.label1);
            this.Name = "SubAccount";
            this.Text = "SubAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ComboBox SubAdit;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox SubAccountTitle;
    }
}