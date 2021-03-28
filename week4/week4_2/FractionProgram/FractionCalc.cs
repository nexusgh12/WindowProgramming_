using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionProgram
{
    public partial class FractionCalc : Form
    {
        public FractionCalc()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        Fraction fr = null;
        private void btnCalc_Click(object sender, EventArgs e)
        {
            int numerator1, numerator2, numerator3=0;
            int denominator1, denominator2, denominator3=0;
            int gcd;
            numerator1 = int.Parse(txtNumerator1.Text);
            numerator2 = int.Parse(txtNumerator2.Text);
            denominator1 = int.Parse(txtDenominator1.Text);
            denominator2 = int.Parse(txtDenominator2.Text);
            numerator3 = 0;
            denominator3 = 0;

            fr = new Fraction(numerator1, denominator1, numerator2, denominator2);
            fr.Calc();

            txtDenominator3.Text = fr.GetDenominator3().ToString();
            txtNumerator3.Text = fr.GetNumerator3().ToString();

        }
    }
}
