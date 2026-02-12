using Microsoft.EntityFrameworkCore;
using RecipeWebApp.Models;

namespace RecipeWebApp.Services
{
    public interface IUserService
    {
        void CreateAccount(User user);
        bool Login(User user);

        public User FindUserById(int id);

        public User FindUserByEmail(string email);
    }
}
