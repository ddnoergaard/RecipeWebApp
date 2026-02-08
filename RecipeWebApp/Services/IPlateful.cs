using RecipeWebApp.Models;

namespace RecipeWebApp.Services
{
    public interface IPlateful
    {
        List<Recipe> GetRecipesToList();
        Recipe GetRecipeById(int id);
    }
}
