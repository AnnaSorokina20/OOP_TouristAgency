using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourAgency
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonA.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = true;
            }
        }

        private void radioButtonR_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonR.Checked)
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

        }
    }
}