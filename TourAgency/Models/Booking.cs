using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourAgency.Models
{
    public class Booking : BaseEntity
    {
        [ForeignKey("Tour")]
        public int TourId { get; set; }

        public Tour Tour { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [MaxLength(20)]
        public string Status { get; set; }
    }
}
