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
    public partial class reviews : UserControl
    {
        public reviews()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset_Controls();

            dataGridView1.Columns.Add("colName", "Book Name");
            dataGridView1.Columns["colName"].DataPropertyName = "name";

            dataGridView1.Columns.Add("colReview", "Book Review");
            dataGridView1.Columns["colReview"].DataPropertyName = "suggestion";

            dataGridView1.Columns[0].Width = 150;

            // Example: Setting the width of the second column to 200 pixels
            dataGridView1.Columns[1].Width = 690;


            dataGridView1.DataSource = SuggestionDL.suggestions;
        }

        private void reviews_Load(object sender, EventArgs e)
        {
            Reset_Controls();
        }
        public void Reset_Controls()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
        }
    }
}
