using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Text;
using System.Globalization;
using System.Diagnostics;

namespace The_Cat_Cafe_Agenda
{
    public partial class Form1 : Form
    {
        int day, month, year;
        public static DateTime Now { get; }

        public Form1()
        {
            //InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            DisplaDays();
        }

        public void DisplaDays()
        {
            //DateTime myDateTime = DateTime.Now;


            DateTime now = DateTime.Now;
            day = now.Day;
            //month = now.Month;
            year = now.Year;

            // Get the first day of the month.

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            //String monthName = DateTimePicker(month);

            LBDATE.Text = monthName + " " + year;

            //DateTime startOfTheMonth = new DateTime(year, month, 1);
            DateTime startofthemonth = new DateTime(year, month, 1);

            // Get the count of days of the month.
            int days = DateTime.DaysInMonth(year, month);

            // Cenvert the startOfTheMonth to integer.
            int dayOfTheWeek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            //Create a blank userControl.
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlEmpty userControlEmpty = new UserControlEmpty();
                daycontainer.Controls.Add(userControlEmpty);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.Days(i);
                daycontainer.Controls.Add(userControlDays);
            }


        }

        public void BtnNext_Click(object sender, EventArgs e)
        {
            // Clear Containers.
            daycontainer.Controls.Clear();

            // Increment month by one.
            month++;

            DateTime startofthemonth = new DateTime(year, month, 1);

            //DateTime.startOfTheMonth = new DateTime(year, month, 1);

            // Get the count of Days of the Month.
            int days = DateTime.DaysInMonth(year, month);

            // Convert the startofthemonth to integer.
            int dayOfTheWeek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlEmpty userControlDays = new UserControlEmpty();
                daycontainer.Controls.Add(userControlDays);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.Days(i);
                daycontainer.Controls.Add(userControlDays);
            }
        }
        private void BtnPrev_Click(object sender, EventArgs e)
        {
            // Clear Containers.
            daycontainer.Controls.Clear();

            // Increment month by one.
            month--;

            DateTime startofthemonth = new DateTime(year, month, 1);

            //DateTime.startOfTheMonth = new DateTime(year, month, 1);

            // Get the count of Days of the Month.
            int days = DateTime.DaysInMonth(year, month);

            // Convert the startofthemonth to integer.
            int dayOfTheWeek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlEmpty userControlDays = new UserControlEmpty();
                daycontainer.Controls.Add(userControlDays);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.Days(i);
                daycontainer.Controls.Add(userControlDays);
            }
        }
    }
}