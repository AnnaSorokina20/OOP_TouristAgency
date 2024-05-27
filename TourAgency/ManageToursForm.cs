using Microsoft.Extensions.DependencyInjection;
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
using TourAgency.Services;

namespace TourAgency
{
    public partial class ManageToursForm : Form
    {
        private readonly UserSession _userSession;
        private readonly ITourService _tourService;
        private readonly IServiceProvider _serviceProvider;

        public ManageToursForm(UserSession userSession, ITourService tourService, IServiceProvider serviceProvider)
        {
            _userSession = userSession;
            _tourService = tourService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void ManageToursForm_Load(object sender, EventArgs e)
        {
            LoadTours();
        }

        private void LoadTours()
        {
            var tours = _tourService.GetAllTours();
            dataGridView1.DataSource = tours;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addEditTourForm = new AddEditTourForm(_tourService);
            addEditTourForm.ShowDialog();
            LoadTours(); // Reload tours after adding a new one
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            var manageBookingForm = _serviceProvider.GetRequiredService<ManageBookingForm>();
            manageBookingForm.Show();
            manageBookingForm.FormClosed += (s, args) => this.Show(); // Возвращаемся к этой форме после закрытия
            this.Hide();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var keyword = textBox1.Text;
            var tours = _tourService.GetAllTours()
                                     .Where(t => t.DepartureCity.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                                t.DestinationCountry.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                                 t.Description.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                                     .ToList();
            dataGridView1.DataSource = tours;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["EditColumn"].Index && e.RowIndex >= 0)
            {
                var tour = (Tour)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                var addEditTourForm = new AddEditTourForm(_tourService, tour);
                addEditTourForm.ShowDialog();
                LoadTours(); // Reload tours after editing
            }

            if (e.ColumnIndex == dataGridView1.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                var tour = (Tour)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                var result = MessageBox.Show("Ви впевнені, що хочете видалити цей тур?", "Підтвердження видалення", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _tourService.DeleteTour(tour.Id);
                    LoadTours(); // Reload tours after deleting
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm == null)
            {
                mainForm = _serviceProvider.GetRequiredService<MainForm>();
                mainForm.Show();
            }
            else
            {
                mainForm.BringToFront();
                mainForm.Show();
            }
            this.Close();

        }
    }
}
