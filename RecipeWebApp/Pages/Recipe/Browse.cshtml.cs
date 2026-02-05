using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeWebApp.Services;

namespace RecipeWebApp.Pages.Recipe
{
    public class BrowseModel : PageModel
    {
        private IPlateful _context;

        [BindProperty]
        public string SearchQuery { get; set; }

        public BrowseModel(IPlateful iPlateful)
        {
            _context = iPlateful;
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
