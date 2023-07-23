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

namespace CityBookCentre.Admin
{
    public partial class UpdateBook : UserControl
    {
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;

            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("colName", "Name");
            dataGridView1.Columns["colName"].DataPropertyName = "name";

            dataGridView1.Columns.Add("colPrice", "Price");
            dataGridView1.Columns["colPrice"].DataPropertyName = "price";

            dataGridView1.Columns.Add("colStock", "Stock");
            dataGridView1.Columns["colStock"].DataPropertyName = "stock";

            dataGridView1.Columns.Add("colCost", "Lending Cost");
            dataGridView1.Columns["colCost"].DataPropertyName = "lendingCost";

            dataGridView1.DataSource = ActiveBookDL.allActiveBooks;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there is a selected row
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Populate textboxes with the data from the selected row
                txtName.Text = selectedRow.Cells["colName"].Value?.ToString();
                txtPrice.Text = selectedRow.Cells["colPrice"].Value?.ToString();
                txtStock.Text = selectedRow.Cells["colStock"].Value?.ToString();
                txtLendingCost.Text = selectedRow.Cells["colCost"].Value?.ToString();
                // Add more textboxes for other columns as needed
            }
            else
            {
                // Clear the textboxes when no row is selected
                txtName.Text = string.Empty;
                txtPrice.Text = string.Empty;
                txtStock.Text = string.Empty;
                txtLendingCost.Text = string.Empty;
                // Add more textboxes for other columns as needed
            }
        }
    }
}
