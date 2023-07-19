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

namespace CityBookCentre
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            ////dataGridView.DataSource = ActiveBookDL.allActiveBooks;
            //dataGridView.Rows.Add(txtName.Text, txtPassword.Text, txtAge.Text);

            //DataTable dataTable = new DataTable();
            //List<ActiveBook> list = ActiveBookDL.allActiveBooks;
            //dataGridView.DataSource = list;
            ////dataGridView.Columns["stock"].Visible = true;

            //txtName.Clear();
            //txtPassword.Clear();
            //txtAge.Clear();
            //txtName.Focus();

            dataGridView.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //// Get the selected row, if any
            //if (dataGridView.SelectedRows.Count > 0)
            //{
            //    int n = dataGridView.SelectedRows.Count;
            //    int selectedFirstIndex = dataGridView.SelectedCells[0].RowIndex - (n-1);
            //    //DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

            //    // Remove the selected row from the DataGridView
            //    dataGridView.Rows.RemoveAt(selectedFirstIndex);
            //}

            dataGridView.DataSource = ActiveBookDL.allActiveBooks;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView.Rows.Add("Ali", "12345", "20");
            ActiveBookDL.allActiveBooks.Add(new ActiveBook("Maths", 1, 2, 3));
            dataGridView.DataSource = ActiveBookDL.allActiveBooks; 
        }
        private void ListForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
