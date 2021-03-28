using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdProblem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double celsius;
            double fahrenheit;

            celsius = Convert.ToInt32(txtCelsius.Text);
            fahrenheit = (celsius * 9 / 5) + 32;
            txtFahrenheit.Text = fahrenheit.ToString();


        }

    }
}
