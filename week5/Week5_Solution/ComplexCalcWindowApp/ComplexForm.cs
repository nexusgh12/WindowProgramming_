using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexCalcWindowApp
{
    
    public partial class ComplexForm : Form
    {
        Complex c1 = null;
        Complex c2 = null;
        Complex c3 = null;

        private double real1, real2;
        private double imaginary1, imaginary2;



        public ComplexForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            real1 = double.Parse(txtReal1.Text);
            real2 = double.Parse(txtReal2.Text);

            imaginary1 = double.Parse(txtImaginary1.Text);
            imaginary2 = double.Parse(txtImaginary1.Text);

            c1 = new Complex(real1, imaginary1);
            c2 = new Complex(real2, imaginary2);

            c3 = c1 + c2;

            txtRealResult.Text = c3.Real.ToString();
            txtImaginaryResult.Text = c3.Imaginary.ToString();

        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            real1 = double.Parse(txtReal1.Text);
            real2 = double.Parse(txtReal2.Text);

            imaginary1 = double.Parse(txtImaginary1.Text);
            imaginary2 = double.Parse(txtImaginary1.Text);

            c1 = new Complex(real1, imaginary1);
            c2 = new Complex(real2, imaginary2);

            c3 = c1 * c2;

            txtRealResult.Text = c3.Real.ToString();
            txtImaginaryResult.Text = c3.Imaginary.ToString();
        }

    }
}
