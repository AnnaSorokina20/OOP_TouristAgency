using System.Collections.Generic;
using TourAgency.Models;

namespace TourAgency.Services
{
    public interface ITourService
    {
        Tour GetTourById(int id);
        List<Tour> GetAllTours();
        void AddTour(Tour tour);
        void UpdateTour(Tour tour);
        void DeleteTour(int id);
    }
}
