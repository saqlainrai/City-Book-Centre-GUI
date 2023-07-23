using CityBookCentre.BL;
using CityBookCentre.CommonLogic;
using CityBookCentre.DL;
using CityBookCentre.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CityBookCentre.Admin;

namespace CityBookCentre
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form form = new Register();
            this.Hide();
            form.Show();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassword.Clear();

            txtName.Focus();
        }
        private void eyeBox_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                eyeBox.BackgroundImage = Properties.Resources.eye_open;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                eyeBox.BackgroundImage = Properties.Resources.eye_close;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtName.Text.Trim().Length > 0)
            {
                if (txtPassword.Text.Trim().Length > 0)
                {
                    string check = commonFunction.signIn(txtName.Text, txtPassword.Text);
                    if (check == "Admin")
                    {
                        Form form = new Admin.Main();
                        this.Hide();
                        form.Show();
                    }
                    else if (check == "User")
                    {
                        Form form = new UserMenu.Main();
                        this.Hide(); 
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("No such User  is Registered");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select a Valid Password", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select a Valid Name", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Welcome_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(630, 300);
            panelTop.Location = new Point(0, 0);
            panelTop.Size = new Size(2000, 30);
            panel2.Location = new Point(1885, 1);
            heading.Location = new Point(690, 200);
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Get the current font of the control
            Font currentFont = heading.Font;
            float currentFontSize = currentFont.Size;
            // Create a new Font with the increased size and the same font family and style
            Font newFont = new Font(currentFont.FontFamily, currentFontSize + 0.25f, currentFont.Style);
            // Set the new font to the control
            heading.Font = newFont;
            if (currentFontSize == 20)
            {
                timer1.Enabled = false;
            }
        }
    }
}
