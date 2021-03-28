using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPointProgram
{
    public partial class ColorPointForm : Form
    {
        Colorble3DPoint c3p = null;
        public ColorPointForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ColorPointForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            int z;
            string color;

            x = int.Parse(txtX.Text);
            y = Convert.ToInt32(txtY.Text);
            z = Convert.ToInt32(txtZ.Text);
            color = txtColor.Text;

            c3p = new Colorble3DPoint(x, y, z, color);
            PrintPoint();

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            int z;
            

            x = int.Parse(txtX.Text);
            y = Convert.ToInt32(txtY.Text);
            z = Convert.ToInt32(txtZ.Text);

            c3p.MoveTo(x, y, z);

            PrintPoint();

        }

        private void PrintPoint()
        {
            txtXPrint.Text = Convert.ToString(c3p.GetX());
            txtYPrint.Text = c3p.Gety() + "";
            txtZPrint.Text = c3p.GetZ().ToString();
            txtColorPrint.Text = c3p.GetColor();
        }

        private void btnChangeX_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(txtX.Text);
            c3p.SetX(x);
            PrintPoint();
        }

        private void btnChangeY_Click(object sender, EventArgs e)
        {
            int y;
            y = int.Parse(txtY.Text);
            c3p.SetY(y);
            PrintPoint();
        }

        private void btnChangeZ_Click(object sender, EventArgs e)
        {
            int z;
            z = int.Parse(txtZ.Text);
            c3p.SetZ(z);
            PrintPoint();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            string color;
            color = txtColor.Text;
            c3p.SetColor(color);
            PrintPoint();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            int z;


            x = int.Parse(txtX.Text);
            y = Convert.ToInt32(txtY.Text);
            z = Convert.ToInt32(txtZ.Text);

            c3p.MoveBy(x, y, z);

            PrintPoint();
        }
    }
}
