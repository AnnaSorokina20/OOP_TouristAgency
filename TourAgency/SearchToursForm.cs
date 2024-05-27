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
    public partial class SearchToursForm : Form
    {
        private readonly ITourService _tourService;
        private readonly IBookingService _bookingService;
        private readonly UserSession _userSession;
        private readonly IServiceProvider _serviceProvider;

        public SearchToursForm(ITourService tourService, IBookingService bookingService, UserSession userSession, IServiceProvider serviceProvider)
        {
            _tourService = tourService;
            _bookingService = bookingService;
            _userSession = userSession;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var departureCity = textBoxDepartureCity.Text;
            var destinationCountry = textBoxDestinationCountry.Text;
            var minPrice = numericUpDownMinPrice.Value;
            var maxPrice = numericUpDownMaxPrice.Value;

            var tours = _tourService.GetAllTours()
                .Where(t => t.Status == "Available" &&
                            (string.IsNullOrEmpty(departureCity) || t.DepartureCity.Contains(departureCity, StringComparison.OrdinalIgnoreCase)) &&
                            (string.IsNullOrEmpty(destinationCountry) || t.DestinationCountry.Contains(destinationCountry, StringComparison.OrdinalIgnoreCase)) &&
                            (minPrice == 0 || t.Price >= minPrice) &&
                            (maxPrice == 0 || t.Price <= maxPrice))
                .ToList();

            dataGridView1.DataSource = tours;
        }

        private void numericUpDownMaxPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownMinPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDestinationCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDepartureCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchToursForm_Load(object sender, EventArgs e)
        {
            LoadAvailableTours();
        }
        private void LoadAvailableTours()
        {
            var tours = _tourService.GetAllTours().Where(t => t.Status == "Available").ToList();
            dataGridView1.DataSource = tours;

            if (!dataGridView1.Columns.Contains("BookColumn"))
            {
                var bookColumn = new DataGridViewButtonColumn
                {
                    Name = "BookColumn",
                    HeaderText = "Бронювати",
                    Text = "Бронювати",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(bookColumn);
            }
        }
        private void buttonMyBooking_Click(object sender, EventArgs e)
        {
            var viewBookingsForm = _serviceProvider.GetRequiredService<ViewBookingsForm>();
            viewBookingsForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            viewBookingsForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["BookColumn"].Index && e.RowIndex >= 0)
            {
                var tour = (Tour)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                var existingBooking = _bookingService.GetAllBookings()
                    .FirstOrDefault(b => b.TourId == tour.Id && b.UserId == _userSession.CurrentUser.Id);

                if (existingBooking != null)
                {
                    MessageBox.Show("Ви вже забронювали цей тур.", "Помилка бронювання", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show($"Ви впевнені, що хочете забронювати тур до {tour.DestinationCountry}?", "Підтвердження бронювання", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var booking = new Booking
                    {
                        TourId = tour.Id,
                        UserId = _userSession.CurrentUser.Id,
                        BookingDate = DateTime.UtcNow,
                        Status = "Pending"
                    };
                    _bookingService.AddBooking(booking);
                    MessageBox.Show("Тур заброньовано успішно!");
                }
            }
        }
    }
}
