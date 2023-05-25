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
    public partial class SubAccount : Form
    {
        public string Month;
        public string Day;
        public string strConn = "Server=localhost;Database=calpie_data;Uid=root;Pwd=0000;";
        public string sql = "SELECT Contect,Month,Day FROM account";
        public MySqlConnection DB;
        public MySqlDataReader rdr;
        public MySqlCommand cmd;

        public SubAccount()
        {
            InitializeComponent();
        }
        public SubAccount(string Month, string Day)
        {
            InitializeComponent();
            DateTime _date = DateTime.Parse(Month + Day);
            this.Month = _date.Month.ToString();
            this.Day = _date.Day.ToString();
            SubAdit.SelectedIndex = 0;
            DB = new MySqlConnection(strConn);
        }

        private void SubAdit_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AditButton_Click(object sender, EventArgs e)//텍스트 금액 입력받기
        {
            if (SubAdit.SelectedIndex == 1) { MessageBox.Show("수정을 선택 후 사용해주세요"); return; }
            cmd = new MySqlCommand(sql, DB);
            DB.Open();
            rdr = cmd.ExecuteReader();
            bool pass = false;
            while (rdr.Read())
            {
                if ((string)rdr["Month"] == this.Month && (string)rdr["Day"] == this.Day && (string)rdr["Contect"] == SubAccountTitle.Text)
                {
                    pass = true;
                    break;
                }
            }
            if (pass == true)
            {
                AditAccount aditAccount = new AditAccount(this.Month, this.Day);
                aditAccount.ShowDialog();
            }
            if (pass == false)
            {
                MessageBox.Show(Month + "월 " + Day + "일 에 입력하신 가계부 데이터가 없습니다.");
                rdr.Close();
                this.Close();

            }
            this.Close();
            DB.Close();



        }
        private void DeleteButton_Click(object sender, EventArgs e)//날짜,제목이 맞아야함,Date,Content
        {
            if (SubAdit.SelectedIndex == 0) { MessageBox.Show("삭제를 선택 후 사용해주세요"); return; }
            DB.Open();
            string sql = "SELECT Contect,Month,Day FROM account";
            MySqlCommand cmd = new MySqlCommand(sql, DB);
            MySqlDataReader rdr = cmd.ExecuteReader();
            bool pass = false;
            
            while (rdr.Read())//폼에서 버튼의 정보 가져오기
            {
                if ((string)rdr["Month"] == this.Month && (string)rdr["Day"] == this.Day && (string)rdr["Contect"] == SubAccountTitle.Text)
                {
                    
                        string sqldelete = "DELETE FROM account WHERE Contect = \'" + SubAccountTitle.Text + "\'";
                        MySqlCommand cmdDelete = new MySqlCommand(sqldelete, DB);
                        DB.Close();
                        DB.Open();
                        rdr = cmdDelete.ExecuteReader();
                        pass = true;
                    
                }
                if (pass == true)
                    MessageBox.Show(Month + "월 " + Day + "일 에 가계부 데이터가 삭제 완료되었습니다.");
                if (pass == false)
                    MessageBox.Show(Month + "월 " + Day + "일 에 입력하신 가계부 데이터가 없습니다.");   
            }
            rdr.Close();
            DB.Close();
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
