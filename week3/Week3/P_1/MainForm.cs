using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int value1, value2;

            value1 = int.Parse(txtValue1.Text);
            value2 = int.Parse(txtValue2.Text);

            unsafe
            {

                swap(&value1, &value2);

            }
            txtValue1.Text = value1.ToString();
            txtValue2.Text = value2.ToString();
        }
        private unsafe void swap(int *p1, int *p2)
        {
            int temp;
            temp = *p1;
            *p1 = *p2;
            *p2 = temp;

        }
    }
}
