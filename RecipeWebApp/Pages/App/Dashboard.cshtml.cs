using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeWebApp.Models;
using RecipeWebApp.Services;

namespace RecipeWebApp.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly PlatefulContext _context;

        private readonly IRecipeService _recipeService;

        public Models.User user { get; set; }

        public Models.Recipe dailyRecipe { get; set; }

        public string todaysDate { get; set; }

        public string today { get; set; } = Convert.ToString(DateTime.Now.DayOfWeek);

        private string _timeOfDay;
        public string timeOfDay
        {
            get { return _timeOfDay; }
            set
            {
                if (Convert.ToInt32(value) < 12)
                {
                    _timeOfDay = "Goodmorning";
                }
                else if (Convert.ToInt32(value) < 16)
                {
                    _timeOfDay = "Good afternoon";
                }
                else
                {
                    _timeOfDay = "Good evening";
                }
            }
        }

        public IndexModel(PlatefulContext platefulContext, IRecipeService recipeS)
        {
            _context = platefulContext;
            _recipeService = recipeS;
            dailyRecipe = _recipeService.GetDailyRecipe();
        }
        public void OnGet(int id)
        {
            user = new Models.User();
            user = _context.Users.FirstOrDefault(u => u.Id == id);
            SessionService.SetCurrentUser(user);
            DateTime tempTodaysDate = DateTime.Today;
            string[] tempArray = Convert.ToString(tempTodaysDate).Split(" ");
            todaysDate = tempArray[0];
            timeOfDay = Convert.ToString(DateTime.Now.Hour);
        }
    }
}
