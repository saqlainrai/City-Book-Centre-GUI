using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CityBookCentre.BL;
using CityBookCentre.DL;

namespace CityBookCentre
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            roleBox.SelectedIndex = 0;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassword.Clear();
            roleBox.SelectedIndex = 0;

            txtName.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
            {
                if (txtPassword.Text.Trim().Length > 0)
                {
                    if (roleBox.SelectedIndex != 0)
                    {
                        User temp = new User(txtName.Text, txtPassword.Text, roleBox.SelectedItem.ToString());
                        UserDL.allUsers.Add(temp);
                        if (addUserInFile("UsersData.txt", temp))
                        {
                            MessageBox.Show("The User is Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Operation Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select a Valid Role", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private bool addUserInFile(string path, User temp)
        {
            if (File.Exists(path))
            {
                StreamWriter file = new StreamWriter(path, true);
                file.WriteLine(temp.name + "," + temp.password + "," + temp.role);
                file.Close();
                return true;    
            } 
            else
            {
                return false;
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
