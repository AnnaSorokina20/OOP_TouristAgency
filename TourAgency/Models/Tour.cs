using System;
using System.ComponentModel.DataAnnotations;

namespace TourAgency.Models
{
    public abstract class Tour : BaseEntity
    {
        [Required, MaxLength(100)]
        public string DepartureCity { get; set; }
        [Required, MaxLength(100)]
        public string DestinationCountry { get; set; }
        [Required]
        public DateTime DepartureDate { get; set; }
        [Required]
        public DateTime ReturnDate { get; set; }
        [Required]
        public decimal Price { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [MaxLength(20)]
        public string Status { get; set; }

        // Добавляем сеттер для TourType и делаем его virtual
        public virtual string TourType { get; protected set; }
    }
}
