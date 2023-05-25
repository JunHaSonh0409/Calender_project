namespace Proj_Calpie
{
    partial class SubMemo
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
            this.MemoText = new System.Windows.Forms.TextBox();
            this.AditButton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MemoText
            // 
            this.MemoText.Location = new System.Drawing.Point(12, 12);
            this.MemoText.Multiline = true;
            this.MemoText.Name = "MemoText";
            this.MemoText.Size = new System.Drawing.Size(323, 99);
            this.MemoText.TabIndex = 0;
            // 
            // AditButton
            // 
            this.AditButton.Location = new System.Drawing.Point(156, 119);
            this.AditButton.Name = "AditButton";
            this.AditButton.Size = new System.Drawing.Size(75, 23);
            this.AditButton.TabIndex = 1;
            this.AditButton.Text = "수정";
            this.AditButton.UseVisualStyleBackColor = true;
            this.AditButton.Click += new System.EventHandler(this.AditButton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(250, 119);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.Text = "취소";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // SubMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 152);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.AditButton);
            this.Controls.Add(this.MemoText);
            this.Name = "SubMemo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SubMemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MemoText;
        private System.Windows.Forms.Button AditButton;
        private System.Windows.Forms.Button Exitbutton;
    }
}