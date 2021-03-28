using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double radius;
            double volume;
            double surface;
            double pi = Math.PI;

            radius = double.Parse(txtRadius.Text);

            volume = (4 / 3) * pi * Math.Pow(radius, 3);

            surface = 4 * pi * Math.Pow(radius, 2);

            txtVolume.Text = volume.ToString();
            txtSurface.Text = surface.ToString();

        }
    }
}
