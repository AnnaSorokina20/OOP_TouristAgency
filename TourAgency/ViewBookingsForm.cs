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
    public partial class ViewBookingsForm : Form
    {
        private readonly IBookingService _bookingService;
        private readonly UserSession _userSession;
        private readonly IServiceProvider _serviceProvider;

        public ViewBookingsForm(IBookingService bookingService, UserSession userSession, IServiceProvider serviceProvider)
        {
            _bookingService = bookingService;
            _userSession = userSession;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void ViewBookingsForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
            var bookings = _bookingService.GetAllBookings()
                .Where(b => b.UserId == _userSession.CurrentUser.Id)
                .ToList();
            dataGridView1.DataSource = bookings;

            if (!dataGridView1.Columns.Contains("CancelColumn"))
            {
                var cancelColumn = new DataGridViewButtonColumn
                {
                    Name = "CancelColumn",
                    HeaderText = "Скасувати",
                    Text = "Скасувати",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(cancelColumn);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["CancelColumn"].Index && e.RowIndex >= 0)
            {
                var booking = (Booking)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                var result = MessageBox.Show("Ви впевнені, що хочете скасувати це бронювання?", "Підтвердження скасування", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _bookingService.DeleteBooking(booking.Id);
                    LoadBookings();
                }
            }
        }

        private void buttonBackToAllTours_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
