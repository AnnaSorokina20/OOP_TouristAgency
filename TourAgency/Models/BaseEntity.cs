using System.ComponentModel.DataAnnotations;

namespace TourAgency.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
