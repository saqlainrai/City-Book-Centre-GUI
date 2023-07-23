using CityBookCentre.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CityBookCentre.UserMenu
{
    public partial class lendBook : UserControl
    {
        public lendBook()
        {
            InitializeComponent();
        }

        private void lendBook_Load(object sender, EventArgs e)
        {
            Reset_Controls();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtLendingCost.Text = string.Empty;

            if (textBox1.Text != string.Empty)
            {
                bool presence = BookDL.findBook(textBox1.Text, ActiveBookDL.allActiveBooks);
                if (presence)
                {
                    txtComment.Text = "Available";
                    txtName.Text = ActiveBookDL.allActiveBooks[Program.idx].getName();
                    txtPrice.Text = (ActiveBookDL.allActiveBooks[Program.idx].getPrice()).ToString();
                    txtStock.Text = (ActiveBookDL.allActiveBooks[Program.idx].getStock()).ToString();
                    txtLendingCost.Text = (ActiveBookDL.allActiveBooks[Program.idx].getLendingCost()).ToString();
                }
                else
                {
                    txtComment.Text = "Unavailable";
                }
            }
            else
            {
                MessageBox.Show("Enter a Valid Name of Book", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                billForm1.Visible = true;
            }
            else
            {
                MessageBox.Show("Enter a Valid Name of Book", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Reset_Controls()
        {
            textBox1.Text = string.Empty;
            txtComment.Text = "Enter the Name of Book";
            billForm1.Visible = false;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtLendingCost.Text = string.Empty;

            textBox1.Focus();
        }
    }
}
