using Microsoft.Identity.Client;
using RecipeWebApp.Models;
namespace RecipeWebApp.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly PlatefulContext _context;

        public Recipe dailyRecipe { get; set; }

        public RecipeService(PlatefulContext platefulContext)
        {
            _context = platefulContext;
        }

        public void GetDailyRecipe()
        {
            List<Recipe> tempRecipes = _context.Recipes.ToList();
            Random rand = new Random();
            int randomNumber = rand.Next(0, tempRecipes.Count-1);
            dailyRecipe = tempRecipes[randomNumber];
        }

        //public void SetDailyRecipe()
        //{

        //}
    }
}
