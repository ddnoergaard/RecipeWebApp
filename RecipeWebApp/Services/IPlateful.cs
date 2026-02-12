using RecipeWebApp.Models;

namespace RecipeWebApp.Services
{
    public interface IPlateful
    {
        List<Recipe> GetRecipesToList();
        Recipe GetRecipeById(int id);
        IEnumerable<Recipe> SearchByQuery(List<Recipe> listR, string searchQuery, string filterOption);
    }
}
