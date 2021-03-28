using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[] array = new int[10] { 1, 3, 4, 5, 6, 7, 9, 8, 2, 0 };

            for (int i = 0; i < 10; i++)
            {
                if( i == 9)
                    txtArray.Text += array[i].ToString();
                else
                    txtArray.Text += array[i].ToString() + ",";
            }

        }
    }
}
