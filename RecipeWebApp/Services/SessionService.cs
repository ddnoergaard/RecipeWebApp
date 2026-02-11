using Microsoft.IdentityModel.Tokens;
using RecipeWebApp.Models;

namespace RecipeWebApp.Services
{
    public class SessionService
    {
        private static User? _loggedInUser = new User();

        public static void SetSessionUser(User user)
        {
            _loggedInUser = user;
        }

        public static User GetSessionUser()
        {
            return _loggedInUser;
        }
    }
}
