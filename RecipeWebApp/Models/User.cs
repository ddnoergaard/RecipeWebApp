using RecipeWebApp.Services;

namespace RecipeWebApp.Models
{
    public class User
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phone;
        private string _password;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone {get; set; }
        public string Password { get; set; }

        public User()
        {
            
        }

        public User(int id, string firstName, string lastName, string email, string phone, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Password = password;
        }
    }
}
