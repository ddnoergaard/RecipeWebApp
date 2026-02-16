using RecipeWebApp.Models;

namespace RecipeWebApp.Services
{
    public interface IRecipeService
    {
        Recipe GetDailyRecipe();
    }
}
