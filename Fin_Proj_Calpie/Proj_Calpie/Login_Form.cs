using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proj_Calpie
{
    public partial class Login_Form : Form
    {
        string PassWord = string.Empty;
        MySqlConnection PW_connect;

        public Login_Form()
        {
            InitializeComponent();
            PW_connect = new MySqlConnection("Server=localhost;Database=calpie_data;Uid=root;Pwd=0000;");
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string PW_find = "SELECT * FROM calpie_data.login_data WHERE PassWord = \'" + PW_Textbox.Text +"\'" ;

            PW_connect.Open();
            MySqlCommand sql_command = new MySqlCommand(PW_find, PW_connect);
            MySqlDataReader reader = sql_command.ExecuteReader();

            while (reader.Read())
            {
                if (PW_Textbox.Text == (string)reader["PassWord"])
                {
                    PW_connect.Close();
                    MessageBox.Show("환영합니다.");
                    MainForm goto_mainform = new MainForm();
                    this.Hide();
                    goto_mainform.ShowDialog();
                    PW_Textbox.Text = default(string);
                    this.Show();
                    return;
                }
            }
            MessageBox.Show("비밀번호가 틀렸습니다.");
            PW_connect.Close();
        }
        private void Find_pw_btn_Click(object sender, EventArgs e)
        {
            Find_Form finding = new Find_Form();
            finding.ShowDialog();
        }

        private void hide_pw_ck_CheckedChanged(object sender, EventArgs e)
        {
            if (hide_pw_ck.Checked == false && PW_Textbox.Text != "")
            {
                PW_Textbox.PasswordChar = '*';
            }
            else
                PW_Textbox.PasswordChar = default(char);
        }


        private void PW_Textbox_TextChanged(object sender, EventArgs e)
        {
            //if(PW_Textbox.Text.ToString().Contains('-') || PW_Textbox.Text.Contains('+') || PW_Textbox.Text.Contains(',') || PW_Textbox.Text.Contains('.'))
            //{
            //    PW_Textbox.Enabled = false;
            //    MessageBox.Show("입력하실 수 없는 문자입니다.");
            //    PW_Textbox.Text = "";
            //    PW_Textbox.Enabled = true;
            //}
            if (hide_pw_ck.Checked == false && PW_Textbox.Text != "")
            {
                PassWord = PW_Textbox.Text;
                PW_Textbox.PasswordChar = '*';
            }
            else
            {
                PW_Textbox.PasswordChar = default(char);
                PassWord = PW_Textbox.Text;
            }
        }

        private void Sign_up_btn_Click(object sender, EventArgs e)
        {
            SignUp_Form sign = new SignUp_Form();
            sign.ShowDialog();
        }

        private void Sign_Del_btn_Click(object sender, EventArgs e)
        {
            string Sign_Find = "SELECT ID FROM calpie_data.login_data";
            string Sign_Delete = "DELETE FROM calpie_data.login_data WHERE ID = 1";

            PW_connect.Open();
            MySqlCommand sql_command = new MySqlCommand(Sign_Find, PW_connect);
            MySqlDataReader reader = sql_command.ExecuteReader();

            MySqlCommand delete_command = new MySqlCommand(Sign_Delete, PW_connect);
            //MySqlDataReader del;

            try
            {
                while(reader.Read())
                {
                    if ((int)reader["ID"] == 1)
                    {
                        if (MessageBox.Show("정말 삭제하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            PW_connect.Close();
                            PW_connect.Open();
                            reader = delete_command.ExecuteReader();
                            MessageBox.Show("계정이 삭제되었습니다.");
                            PW_connect.Close();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("취소하셨습니다.");
                            PW_connect.Close();
                            return;
                        }
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("오류발생.\n");
                PW_connect.Close();
            }
            MessageBox.Show("삭제하실 데이터가 없습니다.\n");
            PW_connect.Close();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
