namespace RecipeWebApp.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PrepTimeMinutes { get; set; }
        public int CookTimeMinutes { get; set; }
        public int Servings { get; set; }
        public string Difficulty { get; set; }
        public string? ImageUrl { get; set; }
        public string DisplayURL => ImageUrl ?? "/content/recipe_images/placeholder_img.png";
        public DateTime CreatedAt { get; set; }
        public string CountryOfOrigin { get; set; }
        public int NumberOfSaves { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public List<RecipeStep> recipeSteps { get; set; }
        
        public Recipe() {}

        public Recipe(int id, string name, string description, int prepTimeMinutes, int cookTimeMinutes, 
            int servings, string difficulty, string imageUrl, DateTime createdAt, string countryOfOrigin)
        {
            Id = id;
            Name = name;
            Description = description;
            PrepTimeMinutes = prepTimeMinutes;
            CookTimeMinutes = cookTimeMinutes;
            Servings = servings;
            Difficulty = difficulty;
            ImageUrl = imageUrl;
            CreatedAt = createdAt;
            CountryOfOrigin = countryOfOrigin;
        }
    }
}
