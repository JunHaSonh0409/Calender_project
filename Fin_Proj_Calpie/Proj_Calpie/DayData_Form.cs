using System;
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
    public partial class DayData_Form : Form
    {
        string month, day;
        DateTime date;
        MySqlConnection conn = new MySqlConnection();

        public DayData_Form()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=calpie_data;Uid=root;Pwd=0000;");
        }

        public DayData_Form(string month, string day)
        {
            InitializeComponent();
            this.date = DateTime.Parse(month + day);
            this.month = month;
            this.day = day;
            conn = new MySqlConnection("Server=localhost;Database=calpie_data;Uid=root;Pwd=0000;");
        }

        private void Form3_Form_Load(object sender, EventArgs e)
        {
            cal();
            mem();
            acc();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //Schedule
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e) //Account Book
        {

        }

        private void ViewDt_btn_Click(object sender, EventArgs e)
        {
            Add_Delete_Form adddel = new Add_Delete_Form(month, day);
            adddel.ShowDialog();

            cal();
            mem();
            acc();
        }

        public void cal()
        {
            listBox1.Items.Clear();
            conn.Open();
            string sql = "SELECT ID, StartMonth, StartDay,StartHour, StartMinute, EndHour, EndMinute, Content FROM calpie_data.schedule limit 5";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if ((string)rdr["StartMonth"] == date.Month.ToString() && (string)rdr["StartDay"] == date.Day.ToString())
                {
                    listBox1.Items.Add(rdr["StartMonth"] + "월" + rdr["StartDay"] + "일 |" + rdr["StartHour"] + " : " + rdr["StartMinute"] + "~"+ rdr["EndHour"] + " : " + rdr["EndMinute"]+"| - " + rdr["Content"]);
                }
            }
            rdr.Close();
            conn.Close();
        }

        public void mem()
        {
            listBox2.Items.Clear();
            conn.Open();
            string Memo = "SELECT Title, Month, Day, Contect FROM calpie_data.memo limit 5";
            MySqlCommand cmd2 = new MySqlCommand(Memo, conn);
            MySqlDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                if ((string)rdr2["Month"] == date.Month.ToString() && (string)rdr2["Day"] == date.Day.ToString())
                {
                    listBox2.Items.Add(rdr2["Month"] + "월" + rdr2["Day"] + "일");
                    listBox2.Items.Add(rdr2["Contect"]);
                }
            }
            rdr2.Close();
            conn.Close();
        }

        public void acc()
        {
            listBox3.Items.Clear();
            conn.Open();
            string Account = "SELECT Contect, Month, Day, Money, Type FROM calpie_data.account";
            MySqlCommand cmd3 = new MySqlCommand(Account, conn);
            MySqlDataReader rdr3 = cmd3.ExecuteReader();
            while (rdr3.Read())
            {
                if ((string)rdr3["Month"] == date.Month.ToString() && (string)rdr3["Day"] == date.Day.ToString())
                {
                    if ((string)rdr3["Type"] == "수입")
                    {
                        listBox3.Items.Add(rdr3["Month"] + "월 " + rdr3["Day"] + "일 " + rdr3["Type"]);
                        listBox3.Items.Add(rdr3["Contect"] + " " + rdr3["Money"] + "원 ");
                    }
                    if ((string)rdr3["Type"] == "지출")
                    {
                        listBox3.Items.Add(rdr3["Month"] + "월 " + rdr3["Day"] + "일 " + rdr3["Type"]);
                        listBox3.Items.Add(rdr3["Contect"] + " " + rdr3["Money"] + "원 ");
                    }
                    //if ((string)rdr3["Type"] == "순수익")
                    //{
                    //    listBox3.Items.Add(rdr3["Month"] + "월 " + rdr3["Day"] + "일 " + rdr3["Type"]);
                    //    listBox3.Items.Add(rdr3["Contect"] + " " + rdr3["PureProfit"] + "원 ");
                    //}
                }
            }
            rdr3.Close();
            conn.Close();
        }
    }
}
