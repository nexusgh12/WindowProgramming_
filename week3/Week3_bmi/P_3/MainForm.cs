using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double weight, height;
            double standardWeight;
            double bmi;
            string obesity;

            weight = double.Parse(txtWeight.Text);
            height = double.Parse(txtHeight.Text);

            standardWeight = (height - 100) * 0.9;
            bmi = (weight - standardWeight) / standardWeight * 100;

            if (bmi < 20)
                obesity = "정상";
            else if (bmi < 30)
                obesity = "경도 비만";
            else if (bmi < 50)
                obesity = "중도 비만";
            else
                obesity = "고도 비만";

            txtStandard.Text = standardWeight.ToString();
            txtBMI.Text = bmi.ToString();
            txtFat.Text = obesity;

        }
    }
}
