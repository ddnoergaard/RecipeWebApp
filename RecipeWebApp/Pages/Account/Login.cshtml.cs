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
            user = new Models.User();
        }

        public IActionResult OnPost()
        {
            if (_userService.Login(user))
            {
                Models.User tempUser = _userService.FindUserByEmail(user.Email);
                return RedirectToPage("/App/Dashboard", new {id = tempUser.Id});
            }
            return Page();
            
        }
    }
}
