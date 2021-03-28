using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactProgram
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        Contact c = null;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            String name, company, cellPhone, tel, mail;
            int age;
            name = txtName.Text;
            age = int.Parse(txtAge.Text);
            company = txtCompany.Text;
            cellPhone = txtCellPhone.Text;
            tel = txtTel.Text;
            mail = txtMail.Text;
            c = new Contact(name, age, company, cellPhone, tel, mail);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           txtPrint.Text =  c.ToString();
        }
    }
}
