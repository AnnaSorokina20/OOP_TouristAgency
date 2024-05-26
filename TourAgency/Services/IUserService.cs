using System.Collections.Generic;
using TourAgency.Models;

namespace TourAgency.Services
{
    public interface IUserService
    {
        User GetUserById(int id);
        List<User> GetAllUsers();
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        User Authenticate(string email, string password);
    }
}
