using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TourAgency.Data;
using TourAgency.Models;
using TourAgency.Services;

namespace TourTests
{
    [TestClass]
    public class UnitTest1
    {
        private TourAgencyContext _context;
        private UserService _userService;
        private TourService _tourService;
        private BookingService _bookingService;

        [TestInitialize]
        public void Initialize()
        {
            var options = new DbContextOptionsBuilder<TourAgencyContext>()
                .UseNpgsql("User ID=postgres;Password=12345678;Host=localhost;Port=5432;Database=toursdb;")
                .Options;

            _context = new TourAgencyContext(options);
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();

            _userService = new UserService(_context);
            _tourService = new TourService(_context);
            _bookingService = new BookingService(_context);
        }

        private User CreateUser(string email) => new User
        {
            Email = email,
            FirstName = "John",
            LastName = "Doe",
            Phone = "1234567890",
            Password = "password",
            IsAdmin = false
        };

        private StandardTour CreateStandardTour(string city) => new StandardTour
        {
            DepartureCity = city,
            DestinationCountry = "CountryA",
            Price = 1000,
            Description = "A great tour",
            DepartureDate = DateTime.UtcNow.AddDays(1),
            ReturnDate = DateTime.UtcNow.AddDays(10),
            Status = "Active"
        };

        private PremiumTour CreatePremiumTour(string city) => new PremiumTour
        {
            DepartureCity = city,
            DestinationCountry = "CountryA",
            Price = 2000,
            Description = "A premium tour",
            DepartureDate = DateTime.UtcNow.AddDays(1),
            ReturnDate = DateTime.UtcNow.AddDays(10),
            Status = "Active"
        };

        private Booking CreateBooking(int userId, int tourId) => new Booking
        {
            UserId = userId,
            TourId = tourId,
            BookingDate = DateTime.UtcNow,
            Status = "Pending"
        };

        [TestMethod]
        public void RegisterUser_ShouldAddUser()
        {
            var user = CreateUser("test@example.com");

            _userService.AddUser(user);
            var addedUser = _context.Users.SingleOrDefault(u => u.Email == user.Email);
            Assert.IsNotNull(addedUser);
            Assert.AreEqual(user.Email, addedUser.Email);
        }

        [TestMethod]
        public void AuthenticateUser_ShouldReturnUser_WhenCredentialsAreValid()
        {
            var user = CreateUser("test@example.com");
            _context.Users.Add(user);
            _context.SaveChanges();

            var result = _userService.Authenticate(user.Email, user.Password);
            Assert.IsNotNull(result);
            Assert.AreEqual(user.Email, result.Email);
        }

        [TestMethod]
        public void AddTour_ShouldAddTour()
        {
            var tour = CreateStandardTour("CityA");

            _tourService.AddTour(tour);
            var addedTour = _context.StandardTours.SingleOrDefault(t => t.DepartureCity == tour.DepartureCity);
            Assert.IsNotNull(addedTour);
            Assert.AreEqual(tour.DepartureCity, addedTour.DepartureCity);
        }

        [TestMethod]
        public void GetAllTours_ShouldReturnAllTours()
        {
            var premiumTour = CreatePremiumTour("CityA");
            var standardTour = CreateStandardTour("CityB");
            _context.PremiumTours.Add(premiumTour);
            _context.StandardTours.Add(standardTour);
            _context.SaveChanges();

            var result = _tourService.GetAllTours();
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("CityA", result.First().DepartureCity);
        }

        [TestMethod]
        public void AddBooking_ShouldAddBooking()
        {
            var user = CreateUser("test@example.com");
            var tour = CreateStandardTour("CityA");
            _context.Users.Add(user);
            _context.StandardTours.Add(tour);
            _context.SaveChanges();

            var booking = CreateBooking(user.Id, tour.Id);

            _bookingService.AddBooking(booking);
            var addedBooking = _context.Bookings.SingleOrDefault(b => b.UserId == user.Id && b.TourId == tour.Id);
            Assert.IsNotNull(addedBooking);
            Assert.AreEqual(booking.UserId, addedBooking.UserId);
        }

        [TestMethod]
        public void GetAllBookings_ShouldReturnAllBookings()
        {
            var user1 = CreateUser("user1@example.com");
            var user2 = CreateUser("user2@example.com");
            var tour1 = CreateStandardTour("CityA");
            var tour2 = CreateStandardTour("CityB");
            _context.Users.AddRange(user1, user2);
            _context.StandardTours.AddRange(tour1, tour2);
            _context.SaveChanges();

            var booking1 = CreateBooking(user1.Id, tour1.Id);
            var booking2 = CreateBooking(user2.Id, tour2.Id);
            _context.Bookings.AddRange(booking1, booking2);
            _context.SaveChanges();

            var result = _bookingService.GetAllBookings();
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual(user1.Id, result.First().UserId);
        }
    }
}
