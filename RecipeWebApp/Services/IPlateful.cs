using RecipeWebApp.Models;

namespace RecipeWebApp.Services
{
    public interface IPlateful
    {
        List<Recipe> GetRecipes();
    }
}
