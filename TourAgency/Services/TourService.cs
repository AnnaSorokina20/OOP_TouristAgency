using System.Collections.Generic;
using System.Linq;
using TourAgency.Data;
using TourAgency.Models;

namespace TourAgency.Services
{
    public class TourService : ITourService
    {
        private readonly TourAgencyContext _context;

        public TourService(TourAgencyContext context)
        {
            _context = context;
        }

        public List<Tour> GetAllTours()
        {
            var premiumTours = _context.PremiumTours.Cast<Tour>().ToList();
            var standardTours = _context.StandardTours.Cast<Tour>().ToList();
            var allTours = premiumTours.Concat(standardTours).ToList();
            return allTours;
        }

        public void AddTour(Tour tour)
        {
            if (tour is PremiumTour)
            {
                _context.PremiumTours.Add(tour as PremiumTour);
            }
            else if (tour is StandardTour)
            {
                _context.StandardTours.Add(tour as StandardTour);
            }
            _context.SaveChanges();
        }

        public void UpdateTour(Tour tour)
        {
            if (tour is PremiumTour)
            {
                _context.PremiumTours.Update(tour as PremiumTour);
            }
            else if (tour is StandardTour)
            {
                _context.StandardTours.Update(tour as StandardTour);
            }
            _context.SaveChanges();
        }

        public Tour GetTourById(int id)
        {
            var premiumTour = _context.PremiumTours.FirstOrDefault(t => t.Id == id);
            if (premiumTour != null) return premiumTour;

            var standardTour = _context.StandardTours.FirstOrDefault(t => t.Id == id);
            return standardTour;
        }

        public void DeleteTour(int id)
        {
            var tour = GetTourById(id);
            if (tour != null)
            {
                if (tour is PremiumTour)
                {
                    _context.PremiumTours.Remove(tour as PremiumTour);
                }
                else if (tour is StandardTour)
                {
                    _context.StandardTours.Remove(tour as StandardTour);
                }
                _context.SaveChanges();
            }
        }
    }
}
