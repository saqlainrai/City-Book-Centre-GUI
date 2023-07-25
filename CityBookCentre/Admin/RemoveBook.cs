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
    public partial class RemoveBook : UserControl
    {
        public RemoveBook()
        {
            InitializeComponent();
        }

        private void RemoveBook_Load(object sender, EventArgs e)
        {
            Reset_Controls();
        }
        public void Reset_Controls()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected row, if any
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int selectedFirstIndex = dataGridView1.SelectedCells[0].RowIndex;
                ////DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                //// Remove the selected row from the DataGridView
                //dataGridView1.Rows.RemoveAt(selectedFirstIndex);

                ActiveBookDL.allActiveBooks.RemoveAt(selectedFirstIndex);
                ActiveBookDL.updateBooksDatainFile(ActiveBookDL.allActiveBooks);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ActiveBookDL.allActiveBooks;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset_Controls();
            if (ActiveBookDL.allActiveBooks.Count > 0)
            {
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
            else
            {
                dataGridView1.Columns.Add("colComment", "Currently No Book is Available on the Board");
            }
        }
    }
}
