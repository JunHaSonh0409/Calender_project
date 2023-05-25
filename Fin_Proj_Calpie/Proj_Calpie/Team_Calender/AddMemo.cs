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
    public partial class AddMemo : Form
    {
        public string Month, Day;
        public AddMemo()
        { InitializeComponent(); }
        public AddMemo(string Month,string Day)
        {
            InitializeComponent();
            //string strConn = "Server=127.0.0.1;Database=madatabase;Uid=root;Pwd=0000;";
            //MySqlConnection DB = new MySqlConnection(strConn);
            //string selectsql = "SELECT Month,Day FROM calander";
            //MySqlCommand scmd = new MySqlCommand(selectsql, DB);
            //MySqlDataReader table = scmd.ExecuteReader();
            this.Text = Month+" "+Day;
            DateTime _date = DateTime.Parse(Month + Day);
            this.Month = _date.Month.ToString();
            this.Day = _date.Day.ToString();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = "Server=localhost;Database=calpie_data;Uid=root;Pwd=0000;";
            MySqlConnection DB = new MySqlConnection(strConn);
            
            string contenttext=MemoBox.Text;
            
            DB.Open();
            string insertdata = "INSERT INTO memo(Month,Day,Contect)" +
             "VALUES ('"+Month+"','"+ Day +"','"+contenttext+"')";
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
