namespace RecipeWebApp.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        public string Unit { get; set; }

        public Ingredient() { }

        public Ingredient(int id, string name, float amount, string unit)
        {
            Id = id;
            Name = name;
            Amount = amount;
            Unit = unit;
        }
    }
}
