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
    public partial class Add_Delete_Form : Form
    {
        string month, day;
        DateTime _Date;
        int i_month, i_day;
        MySqlConnection connecter;

        public Add_Delete_Form()
        {
            InitializeComponent();
            
        }

        public Add_Delete_Form(string month, string day)
        {
            InitializeComponent();
            this.month= month;
            this.day= day;
            _Date = DateTime.Parse(month + day);
        }

        private void Sche_Add_Click(object sender, EventArgs e)
        {
            AddDaily addform = new AddDaily(month, day);
            addform.ShowDialog();
            View_Schedule();
        }

        private void She_Del_Click(object sender, EventArgs e)
        {
            SubDaily subform = new SubDaily(month, day);
            subform.ShowDialog();
            View_Schedule();
        }

        private void Account_Add_Click(object sender, EventArgs e)
        {
            AddAccount addAcform = new AddAccount(month, day);
            addAcform.ShowDialog();
            View_AccountBook();
        }

        private void Account_Del_Click(object sender, EventArgs e)
        {
            SubAccount subAcform = new SubAccount(month, day);
            subAcform.ShowDialog();
            View_AccountBook();
        }

        private void Memo_Add_Click(object sender, EventArgs e)
        {
            AddMemo addmemoform = new AddMemo(month, day);
            addmemoform.ShowDialog();
            View_Memo();
        }

        private void Memo_Del_Click(object sender, EventArgs e)
        {
            SubMemo submemoform = new SubMemo(month, day);
            submemoform.ShowDialog();
            View_Memo();
        }

        private void Add_Delete_Form_Load(object sender, EventArgs e)
        {
            connecter = new MySqlConnection("Server=localhost;Database=calpie_data;Uid=root;Pwd=0000;");
            View_Schedule();
            View_AccountBook();
            View_Memo();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void View_Schedule()
        {
            Schedule_list.Items.Clear();
            string Find_Schedule = "SELECT * FROM calpie_data.schedule WHERE StartMonth = \'" + _Date.Month.ToString() + "\' AND StartDay = \'" + _Date.Day.ToString() + "\'";

            connecter.Open();
            MySqlCommand sql_command = new MySqlCommand(Find_Schedule, connecter);
            MySqlDataReader data_reader = sql_command.ExecuteReader();

            while(data_reader.Read())
            {
                Schedule_list.Items.Add(data_reader["StartHour"]+ ":" + data_reader["StartMinute"] + "~" + data_reader["EndHour"] + ":" + data_reader["EndMinute"] + " " + data_reader["Content"]);
            }
            connecter.Close();
        }

        private void View_AccountBook()
        {
            Account_list.Items.Clear();
            string Find_Account = "SELECT * FROM calpie_data.account WHERE Month = \'" + _Date.Month.ToString() + "\' AND Day = \'" + _Date.Day.ToString() + "\'";
            int income_sum = 0;
            int expen_sum = 0;

            connecter.Open();
            MySqlCommand sql_command = new MySqlCommand(Find_Account, connecter);
            MySqlDataReader data_reader = sql_command.ExecuteReader();

            while (data_reader.Read())
            {
                Account_list.Items.Add(data_reader["Type"] + " " + data_reader["Money"] + "원 : " + data_reader["Contect"]);
                if ((string)data_reader["Type"] == "수익")
                    income_sum = (int)data_reader["Money"];
                if ((string)data_reader["Type"] == "지출")
                    expen_sum = (int)data_reader["Money"];
            }
            connecter.Close();
            income.Text = income_sum.ToString();
            expend.Text = expen_sum.ToString();
        }

        private void View_Memo()
        {
            Memo_TB.Clear();
            string Find_Memo = "SELECT * FROM calpie_data.memo WHERE Month = \'" + _Date.Month.ToString() + "\' AND Day = \'" + _Date.Day.ToString() + "\'";

            connecter.Open();
            MySqlCommand sql_command = new MySqlCommand(Find_Memo, connecter);
            MySqlDataReader data_reader = sql_command.ExecuteReader();

            int length = 10;

            while (data_reader.Read())
            {
                Memo_TB.Text = (string)data_reader["Contect"];
            }
            connecter.Close();
        }
    }
}
