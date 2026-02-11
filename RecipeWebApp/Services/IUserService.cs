using RecipeWebApp.Models;

namespace RecipeWebApp.Services
{
    public interface IUserService
    {
        void CreateAccount(User user);
        bool Login(User user);
    }
}
