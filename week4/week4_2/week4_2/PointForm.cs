using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4_2
{
    public partial class PointForm : Form
    {
        public PointForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Point p = null;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int x;
            int y;

            x = int.Parse(txtX.Text);
            y = int.Parse(txtY.Text);

            p = new Point(x, y);

            txtPrint.Text = p.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            p.MoveTo(int.Parse(txtX.Text), int.Parse(txtY.Text));

            txtPrint.Text = p.ToString();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            p.MoveBy(int.Parse(txtX.Text), int.Parse(txtY.Text));

            txtPrint.Text = p.ToString();
        }
    }
}
