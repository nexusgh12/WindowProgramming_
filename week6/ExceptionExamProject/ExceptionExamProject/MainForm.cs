using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionExamProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int inputValue1 = 0;
            int inputValue2 = 0;

            try
            {
                inputValue1 = int.Parse(txtInput1.Text);
                inputValue2 = int.Parse(txtInput2.Text);
            }
            catch (FormatException fe)
            {
                lblInfo.Text = "입력 형식이 잘못 되었습니다. 다시 입력해주세요.";
                return;
            }
            try
            {
                txtOutput.Text = (inputValue1 / inputValue2).ToString();
            }
            catch(DivideByZeroException dbze)
            {
                txtOutput.Text = "Div/0";
                lblInfo.Text = dbze.Message;
            }


        }
    }
}
