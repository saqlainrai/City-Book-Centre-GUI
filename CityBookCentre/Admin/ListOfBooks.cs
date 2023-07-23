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

namespace CityBookCentre.Admin
{
    public partial class ListOfBooks : UserControl
    {
        public ListOfBooks()
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

            dataGridView1.Columns.Add("colStock", "Stock");
            dataGridView1.Columns["colStock"].DataPropertyName = "stock";

            dataGridView1.Columns.Add("colCost", "Lending Cost");
            dataGridView1.Columns["colCost"].DataPropertyName = "lendingCost";

            // Set the data source to the list of Person objects
            dataGridView1.DataSource = ActiveBookDL.allActiveBooks;
        }
    }
}
