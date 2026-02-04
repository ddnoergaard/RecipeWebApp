using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeWebApp.Services;
using RecipeWebApp.Models;

namespace RecipeWebApp.Pages.Recipe
{
    public class IndexModel : PageModel
    {
        public List<Models.Recipe> Recipes;

        private IPlateful _context;
        public IndexModel(IPlateful iPlateful)
        {
            _context = iPlateful;
        }

        public IActionResult OnGet()
        {
            Recipes = _context.GetRecipes();
            return Page();
        }
    }
}
