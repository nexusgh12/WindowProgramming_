using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int value1, value2;
            value1 = int.Parse(txtValue1.Text);
            value2 = int.Parse(txtValue2.Text);

            if (value1 > value2)
                lblResult.Text = value1 + " > " + value2;
            else if (value1 < value2)
                lblResult.Text = value1 + " < " + value2;
            else
                lblResult.Text = value1 + " = " + value2;


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
