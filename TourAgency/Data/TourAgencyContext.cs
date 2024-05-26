using Microsoft.EntityFrameworkCore;
using TourAgency.Models;

namespace TourAgency.Data
{
    public class TourAgencyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PremiumTour> PremiumTours { get; set; }
        public DbSet<StandardTour> StandardTours { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public TourAgencyContext(DbContextOptions<TourAgencyContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tour>()
                .HasDiscriminator<string>("TourType")
                .HasValue<PremiumTour>("Premium")
                .HasValue<StandardTour>("Standard");

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Tour)
                .WithMany()
                .HasForeignKey(b => b.TourId);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.User)
                .WithMany(u => u.Bookings)
                .HasForeignKey(b => b.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
