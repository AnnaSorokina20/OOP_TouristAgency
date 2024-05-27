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
    public partial class ManageBookingForm : Form
    {
        private readonly UserSession _userSession;
        private readonly IBookingService _bookingService;
        private readonly ITourService _tourService;
        private readonly IServiceProvider _serviceProvider;

        public ManageBookingForm(UserSession userSession, IBookingService bookingService, ITourService tourService, IServiceProvider serviceProvider)
        {
            _userSession = userSession;
            _bookingService = bookingService;
            _tourService = tourService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            LoadBookings();
        }

        private void LoadBookings()
        {
            var bookings = _bookingService.GetAllBookings();
            dataGridView1.DataSource = bookings.ToList();
        }

        private void buttonBackToTours_Click(object sender, EventArgs e)
        {
            var manageToursForm = _serviceProvider.GetRequiredService<ManageToursForm>();
            manageToursForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = textBox1.Text.ToLower();
            var bookings = _bookingService.GetAllBookings()
                .Where(b => b.Tour.DestinationCountry.ToLower().Contains(query) ||
                            b.Tour.DepartureCity.ToLower().Contains(query) ||
                            b.User.Email.ToLower().Contains(query))
                .ToList();
            dataGridView1.DataSource = bookings;
        }
    }
}
