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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proj_Calpie
{
    public partial class Find_Form : Form
    {
        MySqlConnection PW_Find;
        public Find_Form()
        {
            InitializeComponent();
            PW_Find = new MySqlConnection("Server=localhost;Database=calpie_data;Uid=root;Pwd=0000;");
        }

        private void Find_btn_Click(object sender, EventArgs e)
        {
            string PW_find = "SELECT * FROM calpie_data.login_data WHERE Birthday = \'" + PWFind_text.Text + "\'";

            PW_Find.Open();
            MySqlCommand sql_command = new MySqlCommand(PW_find, PW_Find);
            MySqlDataReader reader = sql_command.ExecuteReader();

            while (reader.Read())
            {
                if (PWFind_text.Text == (string)reader["Birthday"])
                {
                    MessageBox.Show("비밀번호 : " + (string)reader["PassWord"]);
                    PW_Find.Close();
                    return;
                    //MainForm goto_mainform = new MainForm();
                    //goto_mainform.Show();
                }
            }
            MessageBox.Show("생년월일이 틀렸습니다.");
            PW_Find.Close();
        }

        private void GoBack_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
