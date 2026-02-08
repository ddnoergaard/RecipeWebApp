using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeWebApp.Services;
using RecipeWebApp.Models;

namespace RecipeWebApp.Pages.Recipe
{
    public class BrowseModel : PageModel
    {
        private IPlateful _context;

        [BindProperty]
        public string SearchQuery { get; set; }

        public List<Models.Recipe> recipes;

        public BrowseModel(IPlateful iPlateful)
        {
            _context = iPlateful;
        }
        public void OnGet()
        {
            recipes = _context.GetRecipesToList();
        }

        public void OnPost()
        {

        }
    }
}
