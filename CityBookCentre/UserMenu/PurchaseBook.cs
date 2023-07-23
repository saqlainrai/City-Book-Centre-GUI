using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CityBookCentre.DL;
using CityBookCentre.BL;

namespace CityBookCentre.UserMenu
{
    public partial class PurchaseBook : UserControl
    {
        public PurchaseBook()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtLendingCost.Text = string.Empty;

            bool presence = BookDL.findBook(txtReference.Text, ActiveBookDL.allActiveBooks);
            if (presence)
            {
                txtComments.Text = "Available";
                txtName.Text = ActiveBookDL.allActiveBooks[Program.idx].getName();
                txtPrice.Text = (ActiveBookDL.allActiveBooks[Program.idx].getPrice()).ToString();
                txtStock.Text = (ActiveBookDL.allActiveBooks[Program.idx].getStock()).ToString();
                txtLendingCost.Text = (ActiveBookDL.allActiveBooks[Program.idx].getLendingCost()).ToString();
            }
            else
            {
                txtComments.Text = "Unavailable";
            }
        }

        private void PurchaseBook_Load(object sender, EventArgs e)
        {
            Reset_Controls();
        }

        public void Reset_Controls()
        {
            txtReference.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtLendingCost.Text = string.Empty;
            txtReference.Focus();
            txtComments.Text = "Enter the Name of Book";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                if (ActiveBookDL.allActiveBooks[Program.idx].getStock() > 0)
                {
                    BookDL.purchaseBook(ActiveBookDL.allActiveBooks, BookDL.purchasedBooks);
                    MessageBox.Show("Book Added to your Cart Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The Book is out of Stock", "Sorry!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select a Valid Book", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Reset_Controls();
        }
    }
}
