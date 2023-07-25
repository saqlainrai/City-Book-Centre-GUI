using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
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
            listOfBooks1.Reset_Controls();

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
            welcome1.Visible = false;
            listOfBooks1.Visible = true;
            purchaseBook1.Visible = false;
            cart1.Visible = false;
            lendBook1.Visible = false;
            previousOrders1.Visible = false;
            feedback1.Visible = false;
        }
        private void btnReviews_Click(object sender, EventArgs e)
        {
            feedback1.Reset_Controls();

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
            welcome1.Visible = false;
            listOfBooks1.Visible = false;
            purchaseBook1.Visible = false;
            cart1.Visible = false;
            lendBook1.Visible = false;
            previousOrders1.Visible = false;
            feedback1.Visible = true;
        }
        private void btnOrders_Click(object sender, EventArgs e)
        {
            previousOrders1.Reset_Controls();
            
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
            welcome1.Visible = false;
            listOfBooks1.Visible = false;
            purchaseBook1.Visible = false;
            cart1.Visible = false;
            lendBook1.Visible = false;
            previousOrders1.Visible = true;
            feedback1.Visible = false;
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            lendBook1.Reset_Controls();

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
            welcome1.Visible = false;
            listOfBooks1.Visible = false;
            purchaseBook1.Visible = false;
            cart1.Visible = false;
            lendBook1.Visible = true;
            previousOrders1.Visible = false;
            feedback1.Visible = false;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            cart1.Reset_Controls();

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
            welcome1.Visible = false;
            listOfBooks1.Visible = false;
            purchaseBook1.Visible = false;
            cart1.Visible = true;
            lendBook1.Visible = false;
            previousOrders1.Visible = false;
            feedback1.Visible = false;

        }
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            purchaseBook1.Reset_Controls();

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
            listOfBooks1.Visible = false;
            purchaseBook1.Visible = true;
            cart1.Visible = false;
            lendBook1.Visible = false;
            previousOrders1.Visible = false;
            feedback1.Visible = false;

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Program.main_welcome_window.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            welcome1.Reset_Controls();
            welcome1.textBox2.Text = "User";

            welcome1.Visible = true;
            listOfBooks1.Visible = false;
            purchaseBook1.Visible = false;
            cart1.Visible = false;
            lendBook1.Visible = false;
            previousOrders1.Visible = false;
            feedback1.Visible = false;

            label1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            btnList.BackColor = panelMenu.BackColor;
            btnPurchase.BackColor = panelMenu.BackColor;
            btnCart.BackColor = panelMenu.BackColor;
            btnLend.BackColor = panelMenu.BackColor;
            btnOrders.BackColor = panelMenu.BackColor;
            btnReviews.BackColor = panelMenu.BackColor;

            welcome1.Visible = true;
            listOfBooks1.Visible = false;
            purchaseBook1.Visible = false;
            cart1.Visible = false;
            lendBook1.Visible = false;
            previousOrders1.Visible = false;
            feedback1.Visible = false;
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

        private void iconCross_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Do you want to Exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
