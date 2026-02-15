using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeWebApp.Models;
using RecipeWebApp.Services;

namespace RecipeWebApp.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly PlatefulContext _context;

        private readonly IRecipeService _recipeService;

        public Models.User user { get; set; }

        public Models.Recipe dailyRecipe { get; set; }

        public IndexModel(PlatefulContext platefulContext, IRecipeService recipeS)
        {
            _context = platefulContext;
            _recipeService = recipeS;
        }
        public void OnGet(int id)
        {
            user = new Models.User();
            user = _context.Users.FirstOrDefault(u => u.Id == id);
            SessionService.SetCurrentUser(user);
        }
    }
}
