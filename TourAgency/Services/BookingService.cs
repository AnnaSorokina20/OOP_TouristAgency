using System.Collections.Generic;
using System.Linq;
using TourAgency.Data;
using TourAgency.Models;

namespace TourAgency.Services
{
    public class BookingService : IBookingService
    {
        private readonly TourAgencyContext _context;

        public BookingService(TourAgencyContext context)
        {
            _context = context;
        }

        public Booking GetBookingById(int id)
        {
            return _context.Bookings.Find(id);
        }

        public List<Booking> GetAllBookings()
        {
            return _context.Bookings.ToList();
        }

        public void AddBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }

        public void UpdateBooking(Booking booking)
        {
            _context.Bookings.Update(booking);
            _context.SaveChanges();
        }

        public void DeleteBooking(int id)
        {
            var booking = _context.Bookings.Find(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                _context.SaveChanges();
            }
        }
    }
}
