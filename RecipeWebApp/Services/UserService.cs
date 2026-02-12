using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RecipeWebApp.Models;

namespace RecipeWebApp.Services
{
    public class UserService : IUserService
    {
        private readonly PasswordHasher<User> _passwordHasher;
        private readonly PlatefulContext _context;

        public UserService(PlatefulContext platefulContext)
        {
            _passwordHasher = new PasswordHasher<User>();
            _context = platefulContext;
        }

        public void CreateAccount(User user)
        {
            User? userEmailCheck = _context.Users.FirstOrDefault(u => u.Email.ToLower() == user.Email.ToLower());
            if (userEmailCheck == null)
            {
                var hashedPassword = _passwordHasher.HashPassword(user, user.Password);
                user.Password = hashedPassword;
                _context.Users.Add(user);
                _context.SaveChanges();
            } else
            {
                throw new Exception("User with that email already exist");
            }
            
        }

        public bool Login(User user)
        {
            User getUser = _context.Users.FirstOrDefault(u => u.Email == user.Email);
            PasswordVerificationResult result = _passwordHasher.VerifyHashedPassword(user, getUser.Password, user.Password);
            if (result == PasswordVerificationResult.Success)
            {
                SessionService.SetSessionUser(_context.Users.FirstOrDefault(u => u.Email == user.Email));
            }
            return result == PasswordVerificationResult.Success ? true : false;
        }

        public User FindUserById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public User FindUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }

    }
}
