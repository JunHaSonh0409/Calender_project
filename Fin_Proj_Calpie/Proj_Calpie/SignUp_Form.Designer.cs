namespace Proj_Calpie
{
    partial class SignUp_Form
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
            this.PW_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Birth_tb = new System.Windows.Forms.TextBox();
            this.Make_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.show_spell = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "비밀번호";
            // 
            // PW_tb
            // 
            this.PW_tb.Location = new System.Drawing.Point(12, 49);
            this.PW_tb.Name = "PW_tb";
            this.PW_tb.PasswordChar = '*';
            this.PW_tb.Size = new System.Drawing.Size(210, 23);
            this.PW_tb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "생년월일";
            // 
            // Birth_tb
            // 
            this.Birth_tb.Location = new System.Drawing.Point(12, 124);
            this.Birth_tb.Name = "Birth_tb";
            this.Birth_tb.Size = new System.Drawing.Size(210, 23);
            this.Birth_tb.TabIndex = 1;
            // 
            // Make_btn
            // 
            this.Make_btn.Location = new System.Drawing.Point(12, 153);
            this.Make_btn.Name = "Make_btn";
            this.Make_btn.Size = new System.Drawing.Size(101, 34);
            this.Make_btn.TabIndex = 2;
            this.Make_btn.Text = "확인";
            this.Make_btn.UseVisualStyleBackColor = true;
            this.Make_btn.Click += new System.EventHandler(this.Make_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(121, 153);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(101, 34);
            this.Cancel_btn.TabIndex = 3;
            this.Cancel_btn.Text = "취소";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // show_spell
            // 
            this.show_spell.AutoSize = true;
            this.show_spell.Location = new System.Drawing.Point(108, 78);
            this.show_spell.Name = "show_spell";
            this.show_spell.Size = new System.Drawing.Size(114, 19);
            this.show_spell.TabIndex = 4;
            this.show_spell.Text = "비밀번호 보이기";
            this.show_spell.UseVisualStyleBackColor = true;
            this.show_spell.CheckedChanged += new System.EventHandler(this.show_spell_CheckedChanged);
            // 
            // SignUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.ControlBox = false;
            this.Controls.Add(this.show_spell);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Make_btn);
            this.Controls.Add(this.Birth_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PW_tb);
            this.Controls.Add(this.label1);
            this.Name = "SignUp_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "계정 추가";
            this.Load += new System.EventHandler(this.SignUp_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PW_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Birth_tb;
        private System.Windows.Forms.Button Make_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.CheckBox show_spell;
    }
}