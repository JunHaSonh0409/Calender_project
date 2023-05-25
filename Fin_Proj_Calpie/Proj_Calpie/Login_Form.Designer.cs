namespace Proj_Calpie
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.Login_btn = new System.Windows.Forms.Button();
            this.PW_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hide_pw_ck = new System.Windows.Forms.CheckBox();
            this.Find_pw_btn = new System.Windows.Forms.Button();
            this.Sign_Del_btn = new System.Windows.Forms.Button();
            this.Sign_up_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(246, 72);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(76, 25);
            this.Login_btn.TabIndex = 0;
            this.Login_btn.Text = "로그인";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // PW_Textbox
            // 
            this.PW_Textbox.Location = new System.Drawing.Point(81, 74);
            this.PW_Textbox.MaxLength = 20;
            this.PW_Textbox.Name = "PW_Textbox";
            this.PW_Textbox.Size = new System.Drawing.Size(159, 23);
            this.PW_Textbox.TabIndex = 1;
            this.PW_Textbox.TextChanged += new System.EventHandler(this.PW_Textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "PW : ";
            // 
            // hide_pw_ck
            // 
            this.hide_pw_ck.AutoSize = true;
            this.hide_pw_ck.BackColor = System.Drawing.Color.Transparent;
            this.hide_pw_ck.Location = new System.Drawing.Point(81, 103);
            this.hide_pw_ck.Name = "hide_pw_ck";
            this.hide_pw_ck.Size = new System.Drawing.Size(114, 19);
            this.hide_pw_ck.TabIndex = 3;
            this.hide_pw_ck.Text = "비밀번호 보이기";
            this.hide_pw_ck.UseVisualStyleBackColor = false;
            this.hide_pw_ck.CheckedChanged += new System.EventHandler(this.hide_pw_ck_CheckedChanged);
            // 
            // Find_pw_btn
            // 
            this.Find_pw_btn.Location = new System.Drawing.Point(208, 103);
            this.Find_pw_btn.Name = "Find_pw_btn";
            this.Find_pw_btn.Size = new System.Drawing.Size(114, 25);
            this.Find_pw_btn.TabIndex = 4;
            this.Find_pw_btn.Text = "비밀번호 찾기";
            this.Find_pw_btn.UseVisualStyleBackColor = true;
            this.Find_pw_btn.Click += new System.EventHandler(this.Find_pw_btn_Click);
            // 
            // Sign_Del_btn
            // 
            this.Sign_Del_btn.Location = new System.Drawing.Point(208, 165);
            this.Sign_Del_btn.Name = "Sign_Del_btn";
            this.Sign_Del_btn.Size = new System.Drawing.Size(114, 25);
            this.Sign_Del_btn.TabIndex = 5;
            this.Sign_Del_btn.Text = "계정 삭제";
            this.Sign_Del_btn.UseVisualStyleBackColor = true;
            this.Sign_Del_btn.Click += new System.EventHandler(this.Sign_Del_btn_Click);
            // 
            // Sign_up_btn
            // 
            this.Sign_up_btn.Location = new System.Drawing.Point(208, 134);
            this.Sign_up_btn.Name = "Sign_up_btn";
            this.Sign_up_btn.Size = new System.Drawing.Size(114, 25);
            this.Sign_up_btn.TabIndex = 6;
            this.Sign_up_btn.Text = "계정 추가";
            this.Sign_up_btn.UseVisualStyleBackColor = true;
            this.Sign_up_btn.Click += new System.EventHandler(this.Sign_up_btn_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.Sign_up_btn);
            this.Controls.Add(this.Sign_Del_btn);
            this.Controls.Add(this.Find_pw_btn);
            this.Controls.Add(this.hide_pw_ck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PW_Textbox);
            this.Controls.Add(this.Login_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 250);
            this.Name = "Login_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox PW_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox hide_pw_ck;
        private System.Windows.Forms.Button Find_pw_btn;
        private System.Windows.Forms.Button Sign_Del_btn;
        private System.Windows.Forms.Button Sign_up_btn;
    }
}
