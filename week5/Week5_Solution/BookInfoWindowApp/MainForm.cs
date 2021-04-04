using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfoWindowApp
{
    public partial class MainForm : Form
    {
        EBook book = null;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title;
            string author;
            int pages;
            string ISBN;
            string publisher;
            int price;

            title = txtTitle.Text;
            author = txtAuthor.Text;
            pages = int.Parse(txtPages.Text);
            ISBN = txtISBN.Text;
            publisher = txtPublisher.Text;
            price = int.Parse(txtPrice.Text);
            
            book = new EBook(title, author, pages, ISBN, publisher, price);


        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            txtResult.Text = book.ToString();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            int discount;
            discount = int.Parse(txtDiscount.Text);
            book.DiscountPrice(discount);
        }

        private void btnOfS_Click(object sender, EventArgs e)
        {
            if (book.OutOfStock == false)
                book.StockOut();
            else
                book.StorageInWareHouse();
        }
    }
}
