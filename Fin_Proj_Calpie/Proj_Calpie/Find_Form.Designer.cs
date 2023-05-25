namespace Proj_Calpie
{
    partial class Find_Form
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
            this.PWFind_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Find_btn = new System.Windows.Forms.Button();
            this.GoBack_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PWFind_text
            // 
            this.PWFind_text.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PWFind_text.Location = new System.Drawing.Point(12, 56);
            this.PWFind_text.Name = "PWFind_text";
            this.PWFind_text.Size = new System.Drawing.Size(210, 27);
            this.PWFind_text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "생년월일 입력";
            // 
            // Find_btn
            // 
            this.Find_btn.Location = new System.Drawing.Point(12, 89);
            this.Find_btn.Name = "Find_btn";
            this.Find_btn.Size = new System.Drawing.Size(100, 34);
            this.Find_btn.TabIndex = 2;
            this.Find_btn.Text = "확인";
            this.Find_btn.UseVisualStyleBackColor = true;
            this.Find_btn.Click += new System.EventHandler(this.Find_btn_Click);
            // 
            // GoBack_btn
            // 
            this.GoBack_btn.Location = new System.Drawing.Point(122, 89);
            this.GoBack_btn.Name = "GoBack_btn";
            this.GoBack_btn.Size = new System.Drawing.Size(100, 34);
            this.GoBack_btn.TabIndex = 3;
            this.GoBack_btn.Text = "취소";
            this.GoBack_btn.UseVisualStyleBackColor = true;
            this.GoBack_btn.Click += new System.EventHandler(this.GoBack_btn_Click);
            // 
            // Find_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(234, 131);
            this.ControlBox = false;
            this.Controls.Add(this.GoBack_btn);
            this.Controls.Add(this.Find_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PWFind_text);
            this.MaximumSize = new System.Drawing.Size(250, 170);
            this.MinimumSize = new System.Drawing.Size(250, 170);
            this.Name = "Find_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "비밀번호 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PWFind_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Find_btn;
        private System.Windows.Forms.Button GoBack_btn;
    }
}