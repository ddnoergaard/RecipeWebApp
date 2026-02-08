namespace RecipeWebApp.Models
{
    public class RecipeStep
    {
        public int Id { get; set; }
        public int StepCount { get; set; }
        public string StepDescription { get; set; }

        public RecipeStep()
        {
            
        }

        public RecipeStep(int id, int stepCount, string stepDescription)
        {
            Id = id;
            StepCount = stepCount;
            StepDescription = stepDescription;
        }
    }
}
