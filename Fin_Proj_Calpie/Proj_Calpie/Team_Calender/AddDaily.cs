using System;
using System.CodeDom;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Proj_Calpie
{

    public partial class AddDaily : Form
    {
        public string Month;
        public string Day;
        public string sm, sd,em,ed;
        public int[] days = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public AddDaily()
        {
            InitializeComponent();
        }
        public AddDaily(string Month, string Day)//콤보박스 초기값
        {
            DateTime _date = DateTime.Parse(Month + Day);
            this.Month = _date.Month.ToString();
            this.Day = _date.Day.ToString();

            InitializeComponent();
            StartDay.Items.Clear();
  
            DateTime today = DateTime.Parse(Month + Day);
            DateTime time = DateTime.Now;
            for (int i = 0; i < days[today.Month-1]; i++)
            {
                StartDay.Items.Add(i + 1);
            }
            StartMonth.SelectedIndex = today.Month - 1;
            sm = (StartMonth.SelectedIndex + 1).ToString();
            StartDay.SelectedIndex = today.Day - 1;
            sd= (StartDay.SelectedIndex + 1).ToString();
            EndMonth.SelectedIndex = today.Month - 1;
            em = (EndMonth.SelectedIndex + 1).ToString();
            EndDay.SelectedIndex = today.Day - 1;
            ed= (EndDay.SelectedIndex + 1).ToString();
            Start_Hour.SelectedIndex=time.Hour;
            Start_Minute.SelectedIndex = 0;
            End_Hour.SelectedIndex = time.Hour+1;
            End_Minute.SelectedIndex = 0;
            ColorType.SelectedIndex = 7;

        }

        private void AddDaily_Load(object sender, EventArgs e)
        {
            this.Text = Month + "월 " + Day+"일";

        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            
                if (((StartMonth.SelectedIndex == EndMonth.SelectedIndex) && (StartDay.SelectedIndex > EndDay.SelectedIndex)) ||
                     ((StartMonth.SelectedIndex > EndMonth.SelectedIndex)) || ((StartMonth.SelectedIndex == EndMonth.SelectedIndex) && (StartDay.SelectedIndex == EndDay.SelectedIndex) && (Start_Hour.SelectedIndex > End_Hour.SelectedIndex)))

                {

                    MessageBox.Show("시작시간이 더 큽니다, 다시 입력해주세요");
                // throw new Exception("시작시간이 더 큽니다, 다시 입력해주세요");
                return;
                }
            
            string strConn = "Server=localhost;Database=calpie_data;Uid=root;Pwd=0000;";
            MySqlConnection DB = new MySqlConnection(strConn);
            DB.Open();
            string starthourindex = Start_Hour.SelectedIndex.ToString();
            string startminuteindex = Start_Minute.SelectedIndex.ToString();
            string endminuteindex = End_Minute.SelectedIndex.ToString();
            string endhourindex = End_Hour.SelectedIndex.ToString();
            string Colorindex = ColorType.SelectedItem.ToString(); ;
            string startmonthindex=StartMonth.SelectedIndex.ToString();
            string startdayindex=StartDay.SelectedIndex.ToString();
            string endmonthindex=EndMonth.SelectedIndex.ToString();
            string enddayindex=EndDay.SelectedIndex.ToString();
            string memotext=MemoBox.Text;
            DataSet ds = new DataSet();
            string insertdata = "INSERT INTO Schedule(StartMonth,StartDay,EndMonth,EndDay,StartHour,EndHour,StartMinute,EndMinute,Color,Content)" +
                "VALUES ("+ sm + "," + sd + "," + em + "," + ed + "," + starthourindex + "," +endhourindex +"," + startminuteindex + "," + endminuteindex + "," + "'" + Colorindex + "'" + "," + "'" + memotext + "'"+")";
            MySqlConnection MyConn2 = new MySqlConnection(strConn);
            MySqlCommand cmd = new MySqlCommand(insertdata, DB);
            cmd.ExecuteNonQuery();
            DB.Close();

            MessageBox.Show("적용되었습니다.");
            this.Close();
        }

   

        private void StartMonth_SelectedIndexChanged(object sender, EventArgs e)
        {   
             StartDay.Items.Clear();
            
            for (int i = 0; i < days[StartMonth.SelectedIndex]; i++)
            {
                        StartDay.Items.Add(i + 1);  
            }

        }

        private void EndMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            EndDay.Items.Clear();

            for (int i = 0; i < days[EndMonth.SelectedIndex]; i++)
            {
                EndDay.Items.Add(i + 1);
            }
        }

        private void NObutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
