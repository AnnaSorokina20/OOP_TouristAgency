using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourAgency.Models;

namespace TourAgency
{
    public partial class ManageToursForm : Form
    {
        private readonly UserSession _userSession;

        public ManageToursForm(UserSession userSession)
        {
            _userSession = userSession;
            InitializeComponent();
        }

        private void ManageToursForm_Load(object sender, EventArgs e)
        {
            var currentUser = _userSession.CurrentUser;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
