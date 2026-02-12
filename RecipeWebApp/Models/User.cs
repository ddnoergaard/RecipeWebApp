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
        public string FirstName
        {
            get { 
                if (SessionService.UserAuthenticate())
                    {
                        return _firstName;
                    } else
                    {
                        return "-";
                    }
                }
            set { _lastName = value; }
        }
        public string LastName {
            get
            {
                if (SessionService.UserAuthenticate())
                {
                    return _lastName;
                }
                else
                {
                    return "-";
                }
            }
            set { _lastName = value; }
        }
        public string Email { get; set; }
        public string Phone {
            get
            {
                if (SessionService.UserAuthenticate())
                {
                    return _phone;
                }
                else
                {
                    return "-";
                }
            }
            set { _phone = value; }
        }
        public string Password {
            get
            {
                if (SessionService.UserAuthenticate())
                {
                    return _password;
                }
                else
                {
                    return "-";
                }
            }
            set { _password = value; }
        }

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
