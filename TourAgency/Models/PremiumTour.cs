namespace TourAgency.Models
{
    public class PremiumTour : Tour
    {
        public override string TourType => "Premium";
        public string ExtraServices { get; set; } // Дополнительные услуги
    }
}
