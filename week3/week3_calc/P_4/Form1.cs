using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_4
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int numerator1, numerator2, numerator3 = 0;
            int denominator1, denominator2, denominator3 = 0;
            int gcd;
            numerator1 = int.Parse(txtNumerator1.Text);
            numerator2 = int.Parse(txtNumerator2.Text);
            denominator1 = int.Parse(txtDenominator1.Text);
            denominator2 = int.Parse(txtDenominator2.Text);

            if(denominator1 == denominator2)
            {
                denominator3 = denominator1;
                numerator3 = numerator1 + numerator2;
            }
            else
            {
                //통분
                numerator3 = (numerator1 * denominator2 + numerator2 * denominator1);
                denominator3 = (denominator1 * denominator2);

            }

            //최대공약수를 찾고 약분
            gcd = GCD(numerator3, denominator3);
            numerator3 /= gcd;
            denominator3 /= gcd;

            txtDenominator3.Text = denominator3.ToString();
            txtNumerator3.Text = numerator3.ToString();

        }
        //재귀함수 이용하여 최대공약수 구하기
        public int GCD(int a, int b)
        {
            return (a % b == 0 ? b : GCD(b, a % b));
        }


    }
}
