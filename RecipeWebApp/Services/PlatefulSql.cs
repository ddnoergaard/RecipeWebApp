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
        public List<Recipe> GetRecipes()
        {
            return _context.recipes.ToList();
        }
    }
}
