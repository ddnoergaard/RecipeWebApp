using Microsoft.EntityFrameworkCore;
using RecipeWebApp.Models;
using System.Collections.Specialized;

namespace RecipeWebApp.Services
{
    public class PlatefulSql : IPlateful
    {
        private PlatefulContext _context;

        public PlatefulSql(PlatefulContext platefulContext)
        {
            _context = platefulContext;
        }
        public List<Recipe> GetRecipesToList()
        {
            try
            {
                var canConnect = _context.Database.CanConnect();
                if (!canConnect)
                {
                    throw new Exception("cannot connect");
                }

                var recipes = _context.Recipes.ToList();

                if (recipes == null || recipes.Count == 0)
                {
                    throw new Exception("No recipes found in database!");
                }

            } catch (Exception e)
            {
                Console.WriteLine($"Error in GetRecipesToList: {e.Message}");
                Console.WriteLine($"Stack trace: {e.StackTrace}");
                throw;
            }
            return _context.Recipes.ToList();
        }

        public Recipe GetRecipeById(int id)
        {
            return _context.Recipes.Include(r => r.recipeSteps.OrderBy(s => s.StepCount)).Include(r => r.ingredients).FirstOrDefault(r => r.Id == id);
        }

        private IEnumerable<Recipe> FilterList(List<Recipe> listR, string filterOption)
        {
            List<Recipe> resultList = new List<Recipe>();
            foreach (Recipe r in listR)
            {
                if (r.Difficulty.ToLower() == filterOption.ToLower())
                {
                    resultList.Add(r);
                }
            }
            return resultList;
        }

        public  IEnumerable<Recipe> SearchByQuery(List<Recipe> listR, string searchQuery, string filterOption)
        {
            List<Recipe> resultList = new List<Recipe>();
            if (searchQuery != "")
            {
                foreach (Recipe r in listR)
                {
                    string[] tempArray = r.Name.Split();
                    foreach (string s in tempArray)
                    {
                        if (searchQuery.ToLower() == s.ToLower())
                        {
                            resultList.Add(r);
                        }
                    }
                }
            }
            if (filterOption != "none")
            {
                return resultList = FilterList(resultList, filterOption).ToList();
            }
            return resultList;
        }
    }
}
