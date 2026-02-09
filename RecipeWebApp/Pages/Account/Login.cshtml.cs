using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeWebApp.Models;

namespace RecipeWebApp.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {

        }

    }
}
