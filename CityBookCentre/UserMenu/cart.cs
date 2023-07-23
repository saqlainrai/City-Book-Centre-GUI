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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;

            // Add columns manually and arrange them according to your desire
            dataGridView1.Columns.Add("colName", "Name");
            dataGridView1.Columns["colName"].DataPropertyName = "name";

            dataGridView1.Columns.Add("colPrice", "Price");
            dataGridView1.Columns["colPrice"].DataPropertyName = "price";

            // Set the data source to the list of Person objects
            dataGridView1.DataSource = BookDL.purchasedBooks;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            billForm1.Visible = true;
            pictureBox1.Visible = false;
        }

        private void cart_Load(object sender, EventArgs e)
        {
            billForm1.Visible = false;
            pictureBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
