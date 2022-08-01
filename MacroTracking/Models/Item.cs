namespace MacroTracking.Models
{
    public class Item
    {
        public Item(int id, string name, decimal calories, decimal protein, decimal carbs, decimal fat, string foodType)
        {
            Id = id;
            Name = name;
            Calories = calories;
            Protein = protein;
            Carbs = carbs;
            Fat = fat;
            FoodType = foodType;
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Calories { get; set; }
        public decimal Protein { get; set; }
        public decimal Carbs { get; set; }
        public decimal Fat { get; set; }
        public string FoodType { get; set; }
    }
}
