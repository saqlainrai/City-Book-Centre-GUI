﻿using CityBookCentre.DL;
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
    public partial class purchasedBooks : UserControl
    {
        public purchasedBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset_Controls();

            dataGridView1.AutoGenerateColumns = false;

            if (UserBookDL.wholeBoughtBooks.Count > 0)
            {
                // Add columns manually and arrange them according to your desire
                dataGridView1.Columns.Add("colUsername", "User Name");
                dataGridView1.Columns["colUsername"].DataPropertyName = "username";

                dataGridView1.Columns.Add("colPassword", "Password");
                dataGridView1.Columns["colPassword"].DataPropertyName = "password";

                dataGridView1.Columns.Add("colName", "Name");
                dataGridView1.Columns["colName"].DataPropertyName = "name";

                dataGridView1.Columns.Add("colPrice", "Price");
                dataGridView1.Columns["colPrice"].DataPropertyName = "price";


                // Set the data source to the list of Person objects
                dataGridView1.DataSource = UserBookDL.wholeBoughtBooks;
            }
            else
            {
                dataGridView1.Columns.Add("colComment", "No Book is Bought Yet");
            }
        }

        private void purchasedBooks_Load(object sender, EventArgs e)
        {
            Reset_Controls();
        }
        public void Reset_Controls()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }
    }
}
