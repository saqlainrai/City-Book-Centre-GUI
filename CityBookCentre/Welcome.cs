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
                        MessageBox.Show("The User is a Valid Admin");
                    }
                    else if (check == "User")
                    {
                        MessageBox.Show("The User is a Valid User");
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
            panel1.Location = new Point(630, 230);
        }
    }
}
