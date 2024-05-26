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

        public Tour GetTourById(int id)
        {
            // Пытаемся найти тур в обоих наборах данных
            var tour = _context.PremiumTours.Find(id) as Tour ?? _context.StandardTours.Find(id);
            return tour;
        }

        public List<Tour> GetAllTours()
        {
            // Объединяем оба набора данных в один список
            return _context.PremiumTours.Cast<Tour>().Concat(_context.StandardTours).ToList();
        }

        public void AddTour(Tour tour)
        {
            if (tour is PremiumTour premiumTour)
            {
                _context.PremiumTours.Add(premiumTour);
            }
            else if (tour is StandardTour standardTour)
            {
                _context.StandardTours.Add(standardTour);
            }
            _context.SaveChanges();
        }

        public void UpdateTour(Tour tour)
        {
            if (tour is PremiumTour premiumTour)
            {
                _context.PremiumTours.Update(premiumTour);
            }
            else if (tour is StandardTour standardTour)
            {
                _context.StandardTours.Update(standardTour);
            }
            _context.SaveChanges();
        }

        public void DeleteTour(int id)
        {
            var tour = GetTourById(id);
            if (tour != null)
            {
                if (tour is PremiumTour premiumTour)
                {
                    _context.PremiumTours.Remove(premiumTour);
                }
                else if (tour is StandardTour standardTour)
                {
                    _context.StandardTours.Remove(standardTour);
                }
                _context.SaveChanges();
            }
        }
    }
}
