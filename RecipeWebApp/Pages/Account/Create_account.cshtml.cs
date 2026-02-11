using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeWebApp.Models;
using RecipeWebApp.Services;

namespace RecipeWebApp.Pages.Account
{
    public class Create_accountModel : PageModel
    {
        private readonly IUserService _userService;

        [BindProperty]
        public Models.User user { get; set; }

        public Create_accountModel(IUserService userService)
        {
            _userService = userService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            try
            {
                _userService.CreateAccount(user);
                return RedirectToPage("/Recipe/Browse");
            } catch (Exception ex)
            {
                ViewData["email-error-message"] = $"{ex.Message}";
                return Page();
            }
        }

    }
}
