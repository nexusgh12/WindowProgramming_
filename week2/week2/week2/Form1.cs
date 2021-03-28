using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2
{
    public partial class frmVolumeCalc : Form
    {
        public frmVolumeCalc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmVolumeCalc_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int width;
            int height;
            int depth;
            int volume;

            width = int.Parse(txtWidth.Text);
            height = int.Parse(txtHeight.Text);
            depth = int.Parse(txtDepth.Text);

            volume = width * height * depth;

            txtVolume.Text = volume.ToString();

        }
    }
}
