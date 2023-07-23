using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityBookCentre.Admin
{
    public partial class welcome : UserControl
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelRole_Click(object sender, EventArgs e)
        {

        }
        public void Reset_Controls()
        {
            textBox1.Text = Program.refUserName;
            textBox3.Text = Program.refUserPassword;
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            Reset_Controls();
        }
    }
}
