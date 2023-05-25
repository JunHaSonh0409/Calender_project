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
    public partial class SubDaily : Form//3월4일 노란색 테스트 시작,끝 날짜3/4 시간 17~18
    {
        public string Month, Day;
        public List<Button> buttonList = new List<Button>();
        public const string RED = "LightCoral";
        public const string ORANGE = "OrangeRed";
        public const string YELLOW = "Yellow";
        public const string GREEN = "SeaGreen";
        public const string BLUE = "CornflowerBlue";
        public const string INDIGO = "RoyalBlue";
        public const string PUPPLE = "Orchid";
        public const string WHITE = "White";
        public int buttonY;
        public int buttonX;
        public string strConn = "Server=localhost;Database=calpie_data;Uid=root;Pwd=0000;";
        public List<int> btnPoint = new List<int>();
        public List<int> btnSize = new List<int>();
        public MySqlConnection DB;
        public MySqlDataReader rdr;
        public MySqlCommand cmd;

        DateTime _date;

        public class DBlist//Content,Color,StartHour,EndHour,StartMinute,EndMinute,Month,Day
        {
            public string Content, Color, StartHour, EndHour, StartMinute, EndMinute;
            
            public DBlist(string Content, string Color, string StartHour, string EndHour, string StartMinute, string EndMinute)
            {
                this.Content = Content;
                this.Color = Color;
                this.StartHour = StartHour;
                this.EndHour = EndHour;
                this.StartMinute = StartMinute;
                this.EndMinute = EndMinute;
            }
           
        }
        public List<DBlist> list = new List<DBlist>();
        public SubDaily()
        {
            InitializeComponent();
        }
        public SubDaily(string Month, string Day)
        {
            InitializeComponent();
            _date = DateTime.Parse(Month + Day);
            this.Month = _date.Month.ToString();
            this.Day = _date.Day.ToString();
    }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void SubDaily_Load(object sender, EventArgs e)//시간 ->location 함수 , 컬러 함수
        {
            int count = 0;
            List<Color>colors= new List<Color>();
            
            string sql = "SELECT Content,Color,StartHour,EndHour,StartMinute,EndMinute,StartMonth,StartDay FROM schedule WHERE StartMonth='" + Month + "' and StartDay='"+Day+"';";
            DB = new MySqlConnection(strConn);
            cmd = new MySqlCommand(sql, DB);
            DB.Open();

            rdr = cmd.ExecuteReader();
           
            while (rdr.Read())
            {
                list.Add(new DBlist((string)rdr["Content"], (string)rdr["Color"], (string)rdr["StartHour"], (string)rdr["EndHour"], (string)rdr["StartMinute"], (string)rdr["EndMinute"]));
                //----------------------------------------컬러----------------------------------------------------------     
                if (list[count].Color == "빨간색")
                    colors.Add(Color.LightCoral);
                else if (list[count].Color == "주황색")
                    colors.Add(Color.OrangeRed);
                else if (list[count].Color == "노란색")
                    colors.Add(Color.Yellow);
                else if (list[count].Color == "초록색")
                    colors.Add(Color.SeaGreen);
                else if (list[count].Color == "파란색")
                    colors.Add(Color.CornflowerBlue);
                else if (list[count].Color == "남색")
                    colors.Add(Color.RoyalBlue);
                else if (list[count].Color == "보라색")
                    colors.Add(Color.Orchid);
                else if (list[count].Color == "흰색")
                    colors.Add(Color.White);

                //-----------------------------------------버튼 로케이션-----------------------------30분단위
                if (int.Parse(list[count].StartHour)==0)
                {
                    if (int.Parse(list[count].StartMinute) > 0 && int.Parse(list[count].StartMinute) <= 59)
                    {
                        btnPoint.Add(20);
                    }
                    else if (int.Parse(list[count].StartMinute) == 0)
                    {
                        btnPoint.Add(0);
                    }
                }
                else if (int.Parse(list[count].StartHour) > 0)
                {
                    if (int.Parse(list[count].StartMinute) > 0 && int.Parse(list[count].StartMinute) <= 59)
                    {
                        btnPoint.Add((int.Parse(list[count].StartHour) * 40)+20);
                    }
                    else if (int.Parse(list[count].StartMinute) == 0)
                    {
                        btnPoint.Add(int.Parse(list[count].StartHour) * 40);
                    }
                }
                //-----------------------------------------버튼 사이즈---------------------------------30분단위           
                try
                {
                    int Hour = int.Parse(list[count].StartHour) - int.Parse(list[count].EndHour);
                    int Min = 0;
                    if (int.Parse(list[count].StartMinute) - int.Parse(list[count].EndMinute) == 0)
                        Min = 0;
                    else if (int.Parse(list[count].StartMinute) - int.Parse(list[count].EndMinute) > 0)
                        Min = 20;
                    else if (int.Parse(list[count].StartMinute) - int.Parse(list[count].EndMinute) < 0)
                        Min = -20;

                    if (Hour == 0)
                        btnSize.Add(40 + Min);
                    else if (Hour < 0)
                        btnSize.Add((Hour * -40) + 20 + Min);                   
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }

                count++;
            }
            rdr.Close();
            DB.Close();
            for (int i = 0; i < list.Count; i++)
            {
                Button btn = new Button();
                this.Controls.Add(btn);
                btn.BackColor = colors[i];
                btn.Enabled = true;
                btn.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
                btn.Location = new Point(45, btnPoint[i]);
                btn.Name = "Dailybtn"+i;
                btn.Size = new Size(219, btnSize[i]);
                btn.TabIndex = 1;
                btn.Text = list[i].Content;
                btn.Tag= list[i].Content;
                btn.UseVisualStyleBackColor = false;   
                panel2.Controls.Add(btn);
                buttonList.Add(btn);
                btn.MouseClick += Btn_MouseClick;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            buttonY = e.Y;
            buttonX = e.X;
        }

        private void Btn_MouseClick(object? sender, MouseEventArgs e)//비지블?
        {       
            if (MessageBox.Show("삭제하시겠습니까?", Month + Day, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sAction = (sender as Control).Tag.ToString();

                for (int i = 0; i < list.Count; i++)
                {
                    if (sAction == list[i].Content)
                    {
                        string sqldelete = "Delete From schedule WHERE StartMonth = '" + this.Month + "'and StartDay='" + this.Day + "'and StartHour='" + list[i].StartHour + "' and Content = '" + list[i].Content + "';";
                        MySqlCommand cmdDelete = new MySqlCommand(sqldelete, DB);
                        DB.Close();
                        DB.Open();
                        rdr = cmdDelete.ExecuteReader();
                        while (rdr.Read())
                        { }

                    }
                }
                
                DB.Close();
                MessageBox.Show("삭제되었습니다.");
                this.Close();
            }
            else 
            {
                MessageBox.Show("삭제 실패하였습니다.");
            }

        }
    }
}
