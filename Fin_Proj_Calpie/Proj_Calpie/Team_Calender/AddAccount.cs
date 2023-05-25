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
    public partial class AddAccount : Form
    { protected string Month;
        protected string Day;
        
        public AddAccount()
        {
            InitializeComponent();
        }
        public AddAccount(string Month,string Day)
        {
            InitializeComponent();
            DateTime _date = DateTime.Parse(Month + Day);
            this.Month = _date.Month.ToString();
            this.Day = _date.Day.ToString();
            this.Text= Month+" "+Day+" 가계부";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accountmoney = AccountMoney.Text;
            string accounttext = AccountText.Text;
            string accounttype = AccountType.Text;
            if (int.Parse(accountmoney) <= 0) 
            {
                MessageBox.Show("올바르지 않는 액수입니다.");
                AccountMoney.Clear();
                return;
            }

            string strConn = "Server=localhost;Database=calpie_data;Uid=root;Pwd=0000;";
            MySqlConnection DB = new MySqlConnection(strConn);
            DB.Open();
           // DataSet ds = new DataSet();
            string insertdata = "INSERT INTO account(Month,Day,Type,Money,Contect)" +
                "VALUES ("+"'"+Month+"','"+Day+"','"+accounttype+"',"+accountmoney+",'"+accounttext+"')";
            MySqlCommand cmd = new MySqlCommand(insertdata, DB);
            cmd.ExecuteNonQuery();
            DB.Close();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
