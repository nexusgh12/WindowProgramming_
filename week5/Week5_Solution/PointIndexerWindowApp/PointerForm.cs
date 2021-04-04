using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointIndexerWindowApp
{
    //델리게이트 선언
    public delegate void MyDelegate(int x, int y);

    public partial class PointerForm : Form
    {
        Point p = null;
        PointArray parr = null;
        MyDelegate myd = null;
        public PointerForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int x;
            int y;

            x = Convert.ToInt32(txtX.Text);
            y = Convert.ToInt32(txtY.Text);

            p = new Point(x, y);
            parr = new PointArray();

            parr[PointArray.count] = p; //인덱서 사용
            
           
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            txtPrint.Text = parr[PointArray.count].ToString();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            myd += new MyDelegate(p.MoveTo);
            myd(int.Parse(txtX.Text), int.Parse(txtY.Text));
            txtPrint.Text = "MoveTo" + Environment.NewLine + p.ToString() + Environment.NewLine;

            myd += new MyDelegate(p.MoveBy);
            myd(int.Parse(txtX.Text), int.Parse(txtY.Text));
            txtPrint.Text += "MoveBy" + Environment.NewLine + p.ToString() + Environment.NewLine;
        }
    }
}
