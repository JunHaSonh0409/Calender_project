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
    public partial class AditAccount : Form
    {
        MySqlConnection DB;
        protected string sql = "Server=localhost;Database=calpie_data;Uid=root;Pwd=0000;";
        SubAccount subaccount= new SubAccount();
        string Month,Day;

       
        public AditAccount()
        {
            InitializeComponent();
        }
        public AditAccount(string Month,string Day)
        {
            InitializeComponent();
            //DateTime _date = DateTime.Parse(Month + Day);
            //this.Month = _date.Month.ToString();
            //this.Day = _date.Day.ToString();

            this.Month = Month;
            this.Day = Day;
        }

        private void Aditbutton_Click(object sender, EventArgs e)//select한다음 업데이트하기 Date,Profit,Content
        {   
           
            try
            {
                SubAccount subaccount = new SubAccount();
                string updatesql = "update account set Contect='" + AditText.Text + "', Money='" + AditMoney.Text + "' where Month='"+Month+"'and Day='"+Day+"';";
                DB = new MySqlConnection(sql);
                MySqlCommand cmd = new MySqlCommand(updatesql, DB);
                MySqlDataReader rdr;
                DB.Open();
                rdr = cmd.ExecuteReader();                    
                rdr.Close();
                MessageBox.Show("수정이 완료되었습니다.");
                
            }
            catch (Exception ex) 
            {  
                MessageBox.Show(ex.Message);               
            }
            finally
            {
                
                DB.Close();
                this.Close();
            }
            
         }
    }
}


       
    
    

