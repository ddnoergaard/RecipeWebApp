using Microsoft.IdentityModel.Tokens;
using RecipeWebApp.Models;

namespace RecipeWebApp.Services
{
    public class SessionService
    {
        private static User? _loggedInUser = new User();

        private static User? _currentUser = new User();

        public static void SetCurrentUser(User user)
        {
            _currentUser = user;
        }

        public static User GetCurrentUser()
        {
            return _currentUser;
        }

        public static void SetSessionUser(User user)
        {
            _loggedInUser = user;
        }

        public static User GetSessionUser()
        {
            return _loggedInUser;
        }

        public static bool UserAuthenticate()
        {
            if (_currentUser.Id == _loggedInUser.Id && _currentUser.Id != 0 && _loggedInUser.Id != 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

    }
}
