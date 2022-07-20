namespace MacroTracking.Models
{
    public class MacroItem
    {
        public MacroItem(int id, string name, double calories, double protein, double carbs, double fat)
        {
            Id = id;
            Name = name;
            Calories = calories;
            Protein = protein;
            Carbs = carbs;
            Fat = fat;
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Calories { get; set; }
        public double Protein { get; set; }

        public double Carbs { get; set; }

        public double Fat { get; set; }
    }
}
