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

namespace CityBookCentre.UserMenu
{
    public partial class cart : UserControl
    {
        public cart()
        {
            InitializeComponent();
            billForm1.DoneClicked += BillForm1_DoneClicked;
        }

        private void BillForm1_DoneClicked(object sender, EventArgs e)
        {
            Reset_Controls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < BookDL.purchasedBooks.Count; i++)
            {
                total += BookDL.purchasedBooks[i].getPrice();
            }

            textBox1.Text = total.ToString();

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;

            if (BookDL.purchasedBooks.Count > 0)
            {

                // Add columns manually and arrange them according to your desire
                dataGridView1.Columns.Add("colName", "Name");
                dataGridView1.Columns["colName"].DataPropertyName = "name";

                dataGridView1.Columns.Add("colPrice", "Price");
                dataGridView1.Columns["colPrice"].DataPropertyName = "price";

                // Set the data source to the list of Person objects
                dataGridView1.DataSource = BookDL.purchasedBooks;
            }
            else
            {
                dataGridView1.Columns.Add("colComment", "No Book is Available in the Cart");
                textBox1.Text = "No Payable Credit";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BookDL.purchasedBooks.Count > 0)
            {
                billForm1.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void cart_Load(object sender, EventArgs e)
        {
            Reset_Controls();            
        }
        public void Reset_Controls()
        {
            textBox1.Text = string.Empty;
            billForm1.Visible = false;
            pictureBox1.Visible = true;
            
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();

            billForm1.form = "Purchase";

            button1.Focus();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
