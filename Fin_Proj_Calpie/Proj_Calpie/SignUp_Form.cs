using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Calpie
{
    public partial class SignUp_Form : Form
    {
        MySqlConnection PW_Find;
        public SignUp_Form()
        {
            InitializeComponent();
        }

        private void SignUp_Form_Load(object sender, EventArgs e)
        {
            PW_Find = new MySqlConnection("Server=localhost;Database=calpie_data;Uid=root;Pwd=0000;");
        }

        private void show_spell_CheckedChanged(object sender, EventArgs e)
        {
            if(show_spell.Checked == true)
                PW_tb.PasswordChar = default(char);
            else
                PW_tb.PasswordChar = '*';
        }

        private void Make_btn_Click(object sender, EventArgs e)
        {
            using (PW_Find)
            {
                string insertQuery = $"INSERT INTO login_data(ID, PassWord, Birthday) VALUES('1',{PW_tb.Text},{Birth_tb.Text})";
                try//예외 처리
                {
                    PW_Find.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, PW_Find);

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("가입을 축하합니다.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("가입하실 수 없습니다.");
                    }
                    //DELETE FROM madatabase.login_data where ID = 3;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("이미 가입하셨습니다.");
                }
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
