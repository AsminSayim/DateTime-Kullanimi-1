using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Kullanımı_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime bugun = DateTime.Now;
        private void btnDate_Click(object sender, EventArgs e)
        {
            label1.Text = bugun.Date.ToString();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            label2.Text = bugun.Month.ToString();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            label3.Text = bugun.Day.ToString();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            label4.Text = bugun.Year.ToString();
        }

        private void btnDayOfWeek_Click(object sender, EventArgs e)
        {
            label5.Text = bugun.DayOfWeek.ToString();
        }

        private void btnDayOfYear_Click(object sender, EventArgs e)
        {
            label6.Text = bugun.DayOfYear.ToString();
        }

        private void btnTimeOfDay_Click(object sender, EventArgs e)
        {
            label7.Text = bugun.TimeOfDay.ToString();
        }

        private void btnHour_Click(object sender, EventArgs e)
        {
            label8.Text = bugun.Hour.ToString();
        }

        private void btnMinute_Click(object sender, EventArgs e)
        {
            label9.Text = bugun.Minute.ToString();

        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            label10.Text = bugun.Second.ToString();
        }

        private void btnMilliSecond_Click(object sender, EventArgs e)
        {
            label11.Text = bugun.Millisecond.ToString();
        }

        private void btnTicks_Click(object sender, EventArgs e)
        {
            label12.Text=bugun.Ticks.ToString();
        }
    }
}
