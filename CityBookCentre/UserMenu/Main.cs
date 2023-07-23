using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CityBookCentre.UserMenu
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            if (btnList.Focused)
            {
                btnList.BackColor = Color.DimGray;
                btnPurchase.BackColor = panelMenu.BackColor;
                btnCart.BackColor = panelMenu.BackColor;
                btnLend.BackColor = panelMenu.BackColor;
                btnOrders.BackColor = panelMenu.BackColor;
                btnReviews.BackColor = panelMenu.BackColor;
            }

            header.Text = "List of Books";
            int centerX = (panelHeader.Width - header.Width) / 2;
            int centerY = (panelHeader.Height - header.Height) / 2;

            // Set the new location of the label
            header.Location = new Point(centerX, centerY);
            listOfBooks1.Visible = true;
        }
        private void btnReviews_Click(object sender, EventArgs e)
        {
            if (btnReviews.Focused)
            {
                btnList.BackColor = panelMenu.BackColor;
                btnPurchase.BackColor = panelMenu.BackColor;
                btnCart.BackColor = panelMenu.BackColor;
                btnLend.BackColor = panelMenu.BackColor;
                btnOrders.BackColor = panelMenu.BackColor;
                btnReviews.BackColor = Color.DimGray;
            }

            header.Text = "Reviews and Suggestions";
            int centerX = (panelHeader.Width - header.Width) / 2;
            int centerY = (panelHeader.Height - header.Height) / 2;

            // Set the new location of the label
            header.Location = new Point(centerX, centerY);
            feedback1.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            if (btnOrders.Focused)
            {
                btnList.BackColor = panelMenu.BackColor;
                btnPurchase.BackColor = panelMenu.BackColor;
                btnCart.BackColor = panelMenu.BackColor;
                btnLend.BackColor = panelMenu.BackColor;
                btnOrders.BackColor = Color.DimGray;
                btnReviews.BackColor = panelMenu.BackColor;
            }

            header.Text = "Your Previous Orders";
            int centerX = (panelHeader.Width - header.Width) / 2;
            int centerY = (panelHeader.Height - header.Height) / 2;

            // Set the new location of the label
            header.Location = new Point(centerX, centerY);
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            if (btnLend.Focused)
            {
                btnList.BackColor = panelMenu.BackColor;
                btnPurchase.BackColor = panelMenu.BackColor;
                btnCart.BackColor = panelMenu.BackColor;
                btnLend.BackColor = Color.DimGray;
                btnOrders.BackColor = panelMenu.BackColor;
                btnReviews.BackColor = panelMenu.BackColor;
            }

            header.Text = "Lend a Book";
            int centerX = (panelHeader.Width - header.Width) / 2;
            int centerY = (panelHeader.Height - header.Height) / 2;

            // Set the new location of the label
            header.Location = new Point(centerX, centerY);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (btnCart.Focused)
            {
                btnList.BackColor = panelMenu.BackColor;
                btnPurchase.BackColor = panelMenu.BackColor;
                btnCart.BackColor = Color.DimGray;
                btnLend.BackColor = panelMenu.BackColor;
                btnOrders.BackColor = panelMenu.BackColor;
                btnReviews.BackColor = panelMenu.BackColor;
            }

            header.Text = "Cart";
            int centerX = (panelHeader.Width - header.Width) / 2;
            int centerY = (panelHeader.Height - header.Height) / 2;

            // Set the new location of the label
            header.Location = new Point(centerX, centerY);
            cart1.Visible = true;
            welcome1.Visible = false;

        }
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (btnPurchase.Focused)
            {
                btnList.BackColor = panelMenu.BackColor;
                btnPurchase.BackColor = Color.DimGray;
                btnCart.BackColor = panelMenu.BackColor;
                btnLend.BackColor = panelMenu.BackColor;
                btnOrders.BackColor = panelMenu.BackColor;
                btnReviews.BackColor = panelMenu.BackColor;
            }

            header.Text = "Purchase a Book";
            int centerX = (panelHeader.Width - header.Width) / 2;
            int centerY = (panelHeader.Height - header.Height) / 2;

            // Set the new location of the label
            header.Location = new Point(centerX, centerY);
            welcome1.Visible = false;
            purchaseBook1.Visible = true;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            welcome1.Visible = true;
            purchaseBook1.Visible = false;
            previousOrders1.Visible = false;
            cart1.Visible = false;
        }
    }
}
