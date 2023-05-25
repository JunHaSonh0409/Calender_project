namespace Proj_Calpie
{
    partial class AditAccount
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
            this.AditText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AditMoney = new System.Windows.Forms.TextBox();
            this.Aditbutton = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AditText
            // 
            this.AditText.Location = new System.Drawing.Point(98, 24);
            this.AditText.Name = "AditText";
            this.AditText.Size = new System.Drawing.Size(183, 23);
            this.AditText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "수정할 제목";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "수정할 금액";
            // 
            // AditMoney
            // 
            this.AditMoney.Location = new System.Drawing.Point(98, 73);
            this.AditMoney.Name = "AditMoney";
            this.AditMoney.Size = new System.Drawing.Size(95, 23);
            this.AditMoney.TabIndex = 3;
            // 
            // Aditbutton
            // 
            this.Aditbutton.Location = new System.Drawing.Point(158, 137);
            this.Aditbutton.Name = "Aditbutton";
            this.Aditbutton.Size = new System.Drawing.Size(74, 23);
            this.Aditbutton.TabIndex = 4;
            this.Aditbutton.Text = "수정";
            this.Aditbutton.UseVisualStyleBackColor = true;
            this.Aditbutton.Click += new System.EventHandler(this.Aditbutton_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(245, 137);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(74, 23);
            this.Closebutton.TabIndex = 5;
            this.Closebutton.Text = "취소";
            this.Closebutton.UseVisualStyleBackColor = true;
            // 
            // AditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 172);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.Aditbutton);
            this.Controls.Add(this.AditMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AditText);
            this.Name = "AditAccount";
            this.Text = "AditAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AditText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AditMoney;
        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Aditbutton;
        private System.Windows.Forms.Button Closebutton;
    }
}