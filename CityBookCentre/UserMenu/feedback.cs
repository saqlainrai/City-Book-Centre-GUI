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
    public partial class feedback : UserControl
    {
        public feedback()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled = true;
        }

        private void feedback_Load(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
            textBox2.Text = "Enter the Name of Book";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                bool presence = BookDL.findBook(textBox1.Text, ActiveBookDL.allActiveBooks);
                if (presence)
                {
                    textBox2.Text = "Available";
                    richTextBox1.Enabled = true;
                }
                else
                {
                    textBox2.Text = "Unavailable";
                }
            }
        }
    }
}
