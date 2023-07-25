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

namespace CityBookCentre.UserMenu
{
    public partial class billForm : UserControl
    {
        public string form;
        public event EventHandler DoneClicked;
        public billForm()
        {
            InitializeComponent();
            form = "Unknown";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //online Payment
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                // bank transfer
                if (radioButton3.Checked && !radioButton4.Checked)
                {
                    if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
                    {
                        if (form == "Purchase")
                        {
                            UserBookDL.transferDatatoNextfile(Program.refUserName, Program.refUserPassword, UserBookDL.wholePurchasedBooks, BookDL.purchasedBooks, UserBookDL.wholeBoughtBooks);
                        }
                        else
                        {
                            ActiveBookDL.allActiveBooks[Program.idx].setStock(ActiveBookDL.allActiveBooks[Program.idx].getStock() - 1);
                        }
                        MessageBox.Show("The Order is Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Valid Credentials", "Failure",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Jazz Cash / EasyPaisa
                else if (!radioButton3.Checked && radioButton4.Checked)
                {
                    if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
                    {
                        if (form == "Purchase")
                        {
                            UserBookDL.transferDatatoNextfile(Program.refUserName, Program.refUserPassword, UserBookDL.wholePurchasedBooks, BookDL.purchasedBooks, UserBookDL.wholeBoughtBooks);
                        }
                        else
                        {
                            ActiveBookDL.allActiveBooks[Program.idx].setStock(ActiveBookDL.allActiveBooks[Program.idx].getStock() - 1);
                        }
                        MessageBox.Show("The Order is Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Valid Credentials", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter an Online Source", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //cash on delivery
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                if (form == "Purchase")
                {
                    UserBookDL.transferDatatoNextfile(Program.refUserName, Program.refUserPassword, UserBookDL.wholePurchasedBooks, BookDL.purchasedBooks, UserBookDL.wholeBoughtBooks);
                }
                else
                {
                    ActiveBookDL.allActiveBooks[Program.idx].setStock(ActiveBookDL.allActiveBooks[Program.idx].getStock() - 1);
                }
                MessageBox.Show("The Order is Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Please choose a Valid Combination", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Reset_Controls();
            DoneClicked?.Invoke(this, null);
        }

        private void billForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset_Controls();
        }

        public void Reset_Controls()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
    }
}
