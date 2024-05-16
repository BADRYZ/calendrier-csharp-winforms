using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal
{
    public partial class Form1 : Form
    {
        public static int _month,_year;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showdays(DateTime.Now.Month,DateTime.Now.Year);
        }

        private void mois_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            _month += 1;
            if(_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showdays(_month, _year);

        }

        private void precedent_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month <1)
            {
                _month = 12;
                _year -= 1;
            }
            showdays(_month, _year);
        }

        private void showdays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _month = month;
            _year = year;
            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            mois.Text = monthName + " " + year;
            DateTime start = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(start.DayOfWeek.ToString("d"));
            for (int i = 1; i < week; i++)
            {
                ucdays uc = new ucdays("");
                flowLayoutPanel1.Controls.Add(uc);

            }
            for (int i = 1; i < day; i++)
            {
                ucdays uc = new ucdays(i+"");
                flowLayoutPanel1.Controls.Add(uc);

            }

        }  
    }
}
