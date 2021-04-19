using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayFormApp
{
    public partial class ArrayForm : Form
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        public ArrayForm()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(txtIndex.Text);
                txtPrint.Text = arr[index].ToString();
            }
            catch (FormatException fe)
            {
                txtPrint.Text = "정수형 인덱스가 입력되지 않았습니다.";
            }catch(IndexOutOfRangeException ioore)
            {
                txtPrint.Text = "배열의 범위를 벗어났습니다.";
            }
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            txtPrint.Text = "";
            for (int i = 0; i<arr.Length; i++)
            {
                if (i != 9)
                    txtPrint.Text += arr[i].ToString() + ", ";
                else
                    txtPrint.Text += arr[i].ToString();
            }
            
        }
    }
}
