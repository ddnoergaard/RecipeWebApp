using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeWebApp.Models;
using RecipeWebApp.Services;

namespace RecipeWebApp.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly PlatefulContext _context;

        public Models.User user { get; set; }

        public IndexModel(PlatefulContext platefulContext)
        {
            _context = platefulContext;
        }
        public void OnGet(int id)
        {
            user = new Models.User();
            user = _context.Users.FirstOrDefault(u => u.Id == id);
            SessionService.SetCurrentUser(user);
        }
    }
}
