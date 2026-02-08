using Microsoft.EntityFrameworkCore;
using RecipeWebApp.Models;
using System.Collections.Specialized;

namespace RecipeWebApp.Services
{
    public class PlatefulSql : IPlateful
    {
        private PlatefulContext _context;

        public PlatefulSql(PlatefulContext bikeStoreContext)
        {
            _context = bikeStoreContext;
        }
        public List<Recipe> GetRecipesToList()
        {
            return _context.recipes.ToList();
        }

        public Recipe GetRecipeById(int id)
        {
            return _context.recipes.Include(r => r.recipeSteps.OrderBy(s => s.StepCount)).Include(r => r.ingredients).FirstOrDefault(r => r.Id == id);
        }

    }
}
