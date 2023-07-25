using CityBookCentre.DL;
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
using static System.Net.Mime.MediaTypeNames;

namespace CityBookCentre.UserMenu
{
    public partial class feedback : UserControl
    {
        public feedback()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty && richTextBox1.Text != "---Enter your Comment Here---")
            {
                SuggestionDL.suggestions.Add(new BL.Suggestion(ActiveBookDL.allActiveBooks[Program.idx].getName(), richTextBox1.Text));
                string path = "suggestions.txt";
                StreamWriter file = new StreamWriter(path, true);
                file.WriteLine(ActiveBookDL.allActiveBooks[Program.idx].getName() + "," + richTextBox1.Text);
                file.Close();
                MessageBox.Show("Your Response is Recorded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please Enter a Commnent", "Request", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Reset_Controls();
        }

        private void feedback_Load(object sender, EventArgs e)
        {
            Reset_Controls();
        }
        public void Reset_Controls()
        {
            richTextBox1.Enabled = false;
            textBox2.Text = "Enter the Name of Book";
            textBox1.Text = string.Empty;
            textBox1.Focus();
            richTextBox1.Text = "---Enter your Comment Here---";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            richTextBox1.Text = "---Enter your Comment Here---";
            richTextBox1.Enabled = false;
            if (textBox1.Text != string.Empty)
            {
                bool presence = BookDL.findBook(textBox1.Text, ActiveBookDL.allActiveBooks);
                if (presence)
                {
                    textBox2.Text = "Available";
                    richTextBox1.Enabled = true;
                    richTextBox1.Text = string.Empty;
                }
                else
                {
                    textBox2.Text = "Unavailable";
                    richTextBox1.Enabled = false;
                }
            }
            else
            {
                richTextBox1.Enabled = false;
                MessageBox.Show("Enter a Valid Name of Book", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
