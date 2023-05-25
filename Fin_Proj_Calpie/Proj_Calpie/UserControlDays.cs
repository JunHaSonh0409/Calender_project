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
    public partial class UserControlDays : UserControl
    {
        string date, month, day;
        DateTime _date;
        public UserControlDays()
        {
            InitializeComponent();
        }
        public UserControlDays(string date)
        {
            InitializeComponent();
            this.date = date;
            _date = DateTime.Parse(date);
            this.month = _date.Month.ToString();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numdays)
        {
            Ibdays.Text = numdays + "";
            date += Ibdays.Text +"일";
            month += "월";
            day += Ibdays.Text + "일";
            if(day == DateTime.Now.Day.ToString() + "일")
            {
                //this.BackColor = SystemColors.Window.
            }
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            DayData_Form form3 = new DayData_Form(month, day);
            form3.ShowDialog();
        }
    }
}
