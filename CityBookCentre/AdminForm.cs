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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            topPanel.Size = new Size(2080, 120);
            topPanel.Location = new Point(0, 0);
            header.Location = new Point (700, 35);
            
            sidePanel.Size = new Size(380, 970);
            sidePanel.Location = new Point(0, 120);
            
            mainPanel.Size = new Size(1800, 970);
            mainPanel.Location = new Point(280, 120);

            option1.Location = new Point(0,120);
            option1.Size = new Size(380, 100);
            
            option2.Location = new Point(0,320);
            option2.Size = new Size(380, 200);
            
            option3.Location = new Point(0,520);
            option3.Size = new Size(380, 200);
            
            option4.Location = new Point(0,720);
            option4.Size = new Size(380, 200);
            
            option5.Location = new Point(0,720);
            option5.Size = new Size(380, 200);
        }
    }
}
