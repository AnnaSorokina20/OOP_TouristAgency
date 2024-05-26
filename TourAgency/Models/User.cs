using System.ComponentModel.DataAnnotations;

namespace TourAgency.Models
{
    public class User : BaseEntity
    {
        [Required, MaxLength(50)]
        public string Email { get; set; }

        [Required, MaxLength(50)]
        public string Password { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

        // Навигационное свойство для бронирований
        public ICollection<Booking> Bookings { get; set; }
    }
}
