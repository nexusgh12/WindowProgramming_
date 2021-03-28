using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointDatatype
{
    public partial class PointForm : Form
    {
        public PointForm()
        {
            InitializeComponent();
        }
        Point<int> point = null;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            x = int.Parse(txtX.Text);
            y = int.Parse(txtY.Text);

            point = new Point<int>(x, y);
            txtPrint.Text = point.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            point.MoveTo(int.Parse(txtX.Text), int.Parse(txtY.Text));

            txtPrint.Text = point.ToString();
        }
    }
}
