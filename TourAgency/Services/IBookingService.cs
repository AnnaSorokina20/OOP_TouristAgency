using System.Collections.Generic;
using TourAgency.Models;

namespace TourAgency.Services
{
    public interface IBookingService
    {
        Booking GetBookingById(int id);
        List<Booking> GetAllBookings();
        void AddBooking(Booking booking);
        void UpdateBooking(Booking booking);
        void DeleteBooking(int id);
    }
}
