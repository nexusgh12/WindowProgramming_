using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateCallWindowApp
{
    public delegate void Calc(int value1, int value2);
    public partial class DelegateForm : Form
    {
        Calc cal = null;
        public DelegateForm()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int value1;
            int value2;
            value1 = int.Parse(txtValue1.Text);
            value2 = int.Parse(txtValue2.Text);

            cal(value1, value2);
        }
        private void add(int value1, int value2)
        {
             txtResult.Text += value1 + " + " + value2 + " = " + (value1 + value2) + Environment.NewLine;
        }
        private void sub(int value1, int value2)
        {
            txtResult.Text += value1 + " - " + value2 + " = " + (value1 - value2) + Environment.NewLine;
        }
        private void mult(int value1, int value2)
        {
            txtResult.Text += value1 + " * " + value2 + " = " + (value1 * value2) + Environment.NewLine;
        }
        private void div(int value1, int value2)
        {
            txtResult.Text += value1 + " / " + value2 + " = " + (value1 / value2) + Environment.NewLine;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cal += new Calc(add);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            cal += new Calc(sub);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            cal += new Calc(mult);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            cal += new Calc(div);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = null;
        }
    }
}
