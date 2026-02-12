using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeWebApp.Services;
using RecipeWebApp.Models;
using Microsoft.IdentityModel.Tokens;

namespace RecipeWebApp.Pages.Recipe
{
    public class BrowseModel : PageModel
    {
        private IPlateful _context;

        [BindProperty]
        public string SearchQuery { get; set; } = "";
        [BindProperty]
        public string SelectOptions { get; set; }

        public bool isASearch { get; set; } = false;

        public List<Models.Recipe> recipes;

        public List<Models.Recipe> DisplayRecipe;

        public BrowseModel(IPlateful iPlateful)
        {
            _context = iPlateful;
        }
        public void OnGet()
        {
            isASearch = false;
            recipes = _context.GetRecipesToList();
            DisplayRecipe = new List<Models.Recipe>();
        }

        public IActionResult OnPost()
        {
            isASearch = true;
            recipes = _context.GetRecipesToList();
            DisplayRecipe = new List<Models.Recipe>();

            string tempSearch = "";

            if (!SearchQuery.IsNullOrEmpty())
            {
                tempSearch = SearchQuery.ToLower();
            }

            if (tempSearch == "" && SelectOptions == "none")
            {
                DisplayRecipe = recipes;
                return Page();
            } else
            {
                DisplayRecipe = _context.SearchByQuery(recipes, SearchQuery, SelectOptions).ToList();

                if (DisplayRecipe.Count == 0)
                {
                    ViewData["error-msg"] = "No recipies matched your search";
                }
                return Page();
            }
        }
    }
}
