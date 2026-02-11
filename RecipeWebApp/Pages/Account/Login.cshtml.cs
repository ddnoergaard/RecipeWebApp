using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeWebApp.Models;
using RecipeWebApp.Services;

namespace RecipeWebApp.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly IUserService _userService;
        [BindProperty]
        public Models.User user { get; set; }

        public LoginModel(IUserService userService)
        {
            _userService = userService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _userService.Login(user);
            return RedirectToPage("/User/Index");
        }

    }
}
