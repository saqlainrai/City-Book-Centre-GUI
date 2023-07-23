using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CityBookCentre.Admin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            welcome1.Visible = true;
            listOfBooks1.Visible = false;
            addBook1.Visible = false;
            removeBook1.Visible = false;
            updateBook1.Visible = false;
            purchasedBooks1.Visible = false;
            rules1.Visible = false;
            reviews1.Visible = false;
            income1.Visible = false;

            label1.Visible = false;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            welcome1.Visible = true;
            listOfBooks1.Visible = false;
            addBook1.Visible = false;
            removeBook1.Visible = false;
            updateBook1.Visible = false;
            purchasedBooks1.Visible = false;
            rules1.Visible = false;
            reviews1.Visible = false;
            income1.Visible = false;
        }
        private void iconCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            if (btnList.Focused)
            {
                btnList.BackColor = Color.DimGray;
                btnAdd.BackColor = panelMenu.BackColor;
                btnRemove.BackColor = panelMenu.BackColor;
                btnUpdate.BackColor = panelMenu.BackColor;
                btnPurchased.BackColor = panelMenu.BackColor;
                btnIncome.BackColor = panelMenu.BackColor;
                btnReviews.BackColor = panelMenu.BackColor;
                btnRules.BackColor = panelMenu.BackColor;
            }

            header.Text = "List of Books";
            int centerX = (panelHeader.Width - header.Width) / 2;
            int centerY = (panelHeader.Height - header.Height) / 2;

            // Set the new location of the label
            header.Location = new Point(centerX, centerY);
            welcome1.Visible = false;
            listOfBooks1.Visible = true;
            addBook1.Visible = false;
            removeBook1.Visible = false;
            updateBook1.Visible = false;
            purchasedBooks1.Visible = false;
            rules1.Visible = false;
            reviews1.Visible = false;
            income1.Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Focused)
            {
                btnAdd.BackColor = Color.DimGray;
                btnList.BackColor = panelMenu.BackColor;
                btnRemove.BackColor = panelMenu.BackColor;
                btnUpdate.BackColor = panelMenu.BackColor;
                btnIncome.BackColor = panelMenu.BackColor;
                btnReviews.BackColor = panelMenu.BackColor;
                btnRules.BackColor = panelMenu.BackColor;
                btnPurchased.BackColor = panelMenu.BackColor;
            }

            header.Text = "Add a Book";
            int centerX = (panelHeader.Width - header.Width) / 2;
            int centerY = (panelHeader.Height - header.Height) / 2;

            // Set the new location of the label
            header.Location = new Point(centerX, centerY);
            welcome1.Visible = false;
            listOfBooks1.Visible = false;
            addBook1.Visible = true;
            removeBook1.Visible = false;
            updateBook1.Visible = false;
            purchasedBooks1.Visible = false;
            rules1.Visible = false;
            reviews1.Visible = false;
            income1.Visible = false;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (btnRemove.Focused)
            {
                btnRemove.BackColor = Color.DimGray;
                btnList.BackColor = panelMenu.BackColor;
                btnAdd.BackColor = panelMenu.BackColor;
                btnUpdate.BackColor = panelMenu.BackColor;
                btnPurchased.BackColor = panelMenu.BackColor;
                btnIncome.BackColor = panelMenu.BackColor;
                btnReviews.BackColor = panelMenu.BackColor;
                btnRules.BackColor = panelMenu.BackColor;
            }

            header.Text = "Remove a Book";
            int centerX = (panelHeader.Width - header.Width) / 2;
            int centerY = (panelHeader.Height - header.Height) / 2;

            // Set the new location of the label
            header.Location = new Point(centerX, centerY);
            welcome1.Visible = false;
            listOfBooks1.Visible = false;
            addBook1.Visible = false;
            removeBook1.Visible = true;
            updateBook1.Visible = false;
            purchasedBooks1.Visible = false;
            rules1.Visible = false;
            reviews1.Visible = false;
            income1.Visible = false;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Focused)
            {
                btnUpdate.BackColor = Color.DimGray;
                btnList.BackColor = panelMenu.BackColor;
                btnAdd.BackColor = panelMenu.BackColor;
                btnRemove.BackColor = panelMenu.BackColor;
                btnIncome.BackColor = panelMenu.BackColor;
                btnReviews.BackColor = panelMenu.BackColor;
                btnPurchased.BackColor = panelMenu.BackColor;
                btnRules.BackColor = panelMenu.BackColor;
            }
            header.Text = "Update a Book";
            int centerX = (panelHeader.Width - header.Width) / 2;
            int centerY = (panelHeader.Height - header.Height) / 2;

            // Set the new location of the label
            header.Location = new Point(centerX, centerY);
            welcome1.Visible = false;
            listOfBooks1.Visible = false;
            addBook1.Visible = false;
            removeBook1.Visible = false;
            updateBook1.Visible = true;
            purchasedBooks1.Visible = false;
            rules1.Visible = false;
            reviews1.Visible = false;
            income1.Visible = false;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnPurchased_Click(object sender, EventArgs e)
        {
            if (btnPurchased.Focused)
            {
                btnPurchased.BackColor = Color.DimGray;
                btnList.BackColor = panelMenu.BackColor;
                btnAdd.BackColor = panelMenu.BackColor;
                btnRemove.BackColor = panelMenu.BackColor;
                btnIncome.BackColor = panelMenu.BackColor;
                btnReviews.BackColor = panelMenu.BackColor;
                btnRules.BackColor = panelMenu.BackColor;
                btnUpdate.BackColor = panelMenu.BackColor;
            }
            header.Text = "Purchased Books";
            int centerX = (panelHeader.Width - header.Width) / 2;
            int centerY = (panelHeader.Height - header.Height) / 2;

            // Set the new location of the label
            header.Location = new Point(centerX, centerY);
            welcome1.Visible = false;
            listOfBooks1.Visible = false;
            addBook1.Visible = false;
            removeBook1.Visible = false;
            updateBook1.Visible = false;
            purchasedBooks1.Visible = true;
            rules1.Visible = false;
            reviews1.Visible = false;
            income1.Visible = false;
        }
        private void btnRules_Click(object sender, EventArgs e)
        {
            if (btnRules.Focused)
            {
                btnRules.BackColor = Color.DimGray;
                btnList.BackColor = panelMenu.BackColor;
                btnAdd.BackColor = panelMenu.BackColor;
                btnRemove.BackColor = panelMenu.BackColor;
                btnIncome.BackColor = panelMenu.BackColor;
                btnReviews.BackColor = panelMenu.BackColor;
                btnUpdate.BackColor = panelMenu.BackColor;
                btnPurchased.BackColor = panelMenu.BackColor;
            }
            header.Text = "Rules and Regulations";
            int centerX = (panelHeader.Width - header.Width) / 2;
            int centerY = (panelHeader.Height - header.Height) / 2;

            // Set the new location of the label
            header.Location = new Point(centerX, centerY);
            welcome1.Visible = false;
            listOfBooks1.Visible = false;
            addBook1.Visible = false;
            removeBook1.Visible = false;
            updateBook1.Visible = false;
            purchasedBooks1.Visible = false;
            rules1.Visible = true;
            reviews1.Visible = false;
            income1.Visible = false;
        }
        private void btnReviews_Click(object sender, EventArgs e)
        {
            if (btnReviews.Focused)
            {
                btnReviews.BackColor = Color.DimGray;
                btnList.BackColor = panelMenu.BackColor;
                btnAdd.BackColor = panelMenu.BackColor;
                btnRemove.BackColor = panelMenu.BackColor;
                btnIncome.BackColor = panelMenu.BackColor;
                btnUpdate.BackColor = panelMenu.BackColor;
                btnRules.BackColor = panelMenu.BackColor;
                btnPurchased.BackColor = panelMenu.BackColor;
            }
            header.Text = "Reviews and Suggestions";
            int centerX = (panelHeader.Width - header.Width) / 2;
            int centerY = (panelHeader.Height - header.Height) / 2;

            // Set the new location of the label
            header.Location = new Point(centerX, centerY);
            welcome1.Visible = false;
            listOfBooks1.Visible = false;
            addBook1.Visible = false;
            removeBook1.Visible = false;
            updateBook1.Visible = false;
            purchasedBooks1.Visible = false;
            rules1.Visible = false;
            reviews1.Visible = true;
            income1.Visible = false;
        }
        private void btnIncome_Click(object sender, EventArgs e)
        {
            if (btnIncome.Focused)
            {
                btnIncome.BackColor = Color.DimGray;
                btnList.BackColor = panelMenu.BackColor;
                btnAdd.BackColor = panelMenu.BackColor;
                btnRemove.BackColor = panelMenu.BackColor;
                btnUpdate.BackColor = panelMenu.BackColor;
                btnReviews.BackColor = panelMenu.BackColor;
                btnRules.BackColor = panelMenu.BackColor;
                btnPurchased.BackColor = panelMenu.BackColor;
            }
            header.Text = "Income Statistics";
            int centerX = (panelHeader.Width - header.Width) / 2;
            int centerY = (panelHeader.Height - header.Height) / 2;

            // Set the new location of the label
            header.Location = new Point(centerX, centerY);
            welcome1.Visible = false;
            listOfBooks1.Visible = false;
            addBook1.Visible = false;
            removeBook1.Visible = false;
            updateBook1.Visible = false;
            purchasedBooks1.Visible = false;
            rules1.Visible = false;
            reviews1.Visible = false;
            income1.Visible = true;
        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            //System.Windows.Forms.Label text = new System.Windows.Forms.Label();
            //text.Text = "City Book Centre is non-profit organization \n working for sake of freedom";
            //text.Location = new Point(500, 500);
            //text.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            //text.Visible = true;
            //text.Enabled = true;
            //text.ForeColor = Color.Black;
            //text.BackColor = Color.White;
            //this.Controls.Add(text);

            label1.Text = "City Book Centre is a Book Store Management System.\n It is a non-profit Organization.";
            for (int x = 0; x < 10; x++)
            {
                label2.Location = new Point(label2.Left - 20, label2.Top);
                Thread.Sleep(100);
            }
            label1.Visible = true;
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;            
            for (int x = 0; x < 10; x++)
            {
                label2.Location = new Point(label2.Left + 20, label2.Top);
                Thread.Sleep(100);
            }
        }
    }
}
