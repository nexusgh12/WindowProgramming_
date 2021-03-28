using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int month;
            int day;
            month = int.Parse(txtMonth.Text);
            switch(month)
            {
                case 1: 
                    day = DateTime.DaysInMonth(2021, month);
                    txtDay.Text = day.ToString();
                    break;
                case 2:
                    day = DateTime.DaysInMonth(2021, month);
                    txtDay.Text = day.ToString();
                    break;
                case 3:
                    day = DateTime.DaysInMonth(2021, month);
                    txtDay.Text = day.ToString();
                    break;
                case 4:
                    day = DateTime.DaysInMonth(2021, month);
                    txtDay.Text = day.ToString();
                    break;
                case 5:
                    day = DateTime.DaysInMonth(2021, month);
                    txtDay.Text = day.ToString();
                    break;
                case 6:
                    day = DateTime.DaysInMonth(2021, month);
                    txtDay.Text = day.ToString();
                    break;
                case 7:
                    day = DateTime.DaysInMonth(2021, month);
                    txtDay.Text = day.ToString();
                    break;
                case 8:
                    day = DateTime.DaysInMonth(2021, month);
                    txtDay.Text = day.ToString();
                    break;
                case 9:
                    day = DateTime.DaysInMonth(2021, month);
                    txtDay.Text = day.ToString();
                    break;
                case 10:
                    day = DateTime.DaysInMonth(2021, month);
                    txtDay.Text = day.ToString();
                    break;
                case 11:
                    day = DateTime.DaysInMonth(2021, month);
                    txtDay.Text = day.ToString();
                    break;
                case 12:
                    day = DateTime.DaysInMonth(2021, month);
                    txtDay.Text = day.ToString();
                    break;
            }


        }
    }
}
