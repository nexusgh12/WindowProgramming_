using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicPoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PointPublic<int> point = null;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            x = int.Parse(txtX.Text);
            y = int.Parse(txtY.Text);

            point = new PointPublic<int>(x, y);
            point.ToString();
        }
    }
}
