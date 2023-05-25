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
    public partial class SubMemo : Form
    {
        public string Month;
        public string Day;
        public string strConn = "Server=localhost;Database=calpie_data;Uid=root;Pwd=0000;";
        public string sql = "SELECT Contect,Month,Day FROM memo";
        public MySqlConnection DB;
        public MySqlDataReader rdr;
        public MySqlCommand cmd;
       
        public SubMemo()
        {
            InitializeComponent();
        }

        public SubMemo(string month, string day)
        {
            InitializeComponent();
            DateTime _date = DateTime.Parse(month + day);
            this.Month = _date.Month.ToString();
            this.Day = _date.Day.ToString();
            DB = new MySqlConnection(strConn);
        }
        private void AditButton_Click(object sender, EventArgs e)
        {
            cmd= new MySqlCommand(sql,DB);
            DB.Open();
            rdr= cmd.ExecuteReader();
            bool pass = false;
            while (rdr.Read())
            {
                if ((string)rdr["Month"] == this.Month && (string)rdr["Day"] == this.Day )
                { 
                    pass = true;
                    break;
                }
            }
            if (pass) 
            {
                string updatesql = "UPDATE memo SET Contect='" + MemoText.Text + "'WHERE Month = '" + this.Month + "'and Day='" + this.Day + "';";
                MySqlCommand cmd = new MySqlCommand(updatesql, DB);              
                DB.Close();
                DB.Open();
                rdr = cmd.ExecuteReader();
                rdr.Close();
                MessageBox.Show("수정이 완료되었습니다.");
                DB.Close();
                this.Close();
            }
            if (pass == false)
            {
                MessageBox.Show(Month + "월 " + Day + "일 에 입력하신 메모 데이터가 없습니다.");
                rdr.Close();
                this.Close();
            }
            
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubMemo_Load(object sender, EventArgs e)
        {
            //AddMemo addmemo = new AddMemo(this.Month,this.Day);//텍스트 불러오기
            this.Text = this.Month + "월 " + this.Day +"일 메모장";
            cmd = new MySqlCommand(sql, DB);
            DB.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if ((string)rdr["Month"] == this.Month && (string)rdr["Day"] == this.Day)
                {
                    MemoText.Text += (string)rdr["Contect"] + "\r\n";
                }
            }
            DB.Close();
        }
    }
}
