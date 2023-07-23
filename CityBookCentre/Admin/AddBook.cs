using CityBookCentre.DL;
using CityBookCentre.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityBookCentre.Admin
{
    public partial class AddBook : UserControl
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Focused)
            {
                button1.BackColor = Color.DarkSlateGray;
            }

            ActiveBook temp = new ActiveBook(txtName.Text, int.Parse(txtPrice.Text), int.Parse(txtStock.Text), int.Parse(txtCost.Text));
            ActiveBookDL.allActiveBooks.Add(temp);

            MessageBox.Show("The Book is Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Reset_Controls();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            Reset_Controls();
        }
        public void Reset_Controls()
        { 
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtCost.Text = string.Empty;
            txtName.Focus();
        }
    }
}
