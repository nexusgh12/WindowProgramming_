using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_Project
{
    //델리게이트 선언
    public delegate void MyDelegate(int x, int y);

    public partial class PointForm : Form
    {
        Point p = null;
        PointArray parr = null;
        public PointForm()
        {
            InitializeComponent();
        }

        private void PointForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int x;
            int y;

            x = Convert.ToInt32(txtX.Text);
            y = Convert.ToInt32(txtY.Text);

            p = new Point(x, y);
            parr = new PointArray();

            //parr.setArray(p, 0); // 메소드 사용시
            parr[0] = p;//인덱서 사용
            //txtPrint.Text = p.ToString();
            txtPrint.Text = parr[0].ToString();


        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            x = int.Parse(txtX.Text);
            y = int.Parse(txtY.Text);

            p.MoveTo(x, y);
            txtPrint.Text = p.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(int.Parse(txtX.Text), int.Parse(txtY.Text));
            Point p2 = new Point(int.Parse(txtX2.Text), int.Parse(txtY2.Text));
            Point p3 = p1 + p2;

            txtPrint.Text = p3.ToString();


        }

        private void btnMoveBy_Click(object sender, EventArgs e) //특정 메소드를 대신 호출해주거나 할 수 있음
        {
            MyDelegate myd = new MyDelegate(p.MoveBy);
            myd(int.Parse(txtX.Text), int.Parse(txtY.Text));
            txtPrint.Text = p.ToString();
            myd = new MyDelegate(p.MoveTo);
            myd(int.Parse(txtX.Text), int.Parse(txtY.Text));
            myd += new MyDelegate(p.MoveBy);
            myd -= new MyDelegate(p.MoveTo);
        }
    }
}
