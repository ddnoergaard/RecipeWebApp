using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeWebApp.Services;
using RecipeWebApp.Models;

namespace RecipeWebApp.Pages.Recipe
{
    public class IndexModel : PageModel
    {
        public Models.Recipe Recipe { get; set; }

        private IPlateful _context;
        public IndexModel(IPlateful iPlateful)
        {
            _context = iPlateful;
        }

        public IActionResult OnGet(int id)
        {
            Recipe = _context.GetRecipeById(id);
            return Page();
        }
    }
}
