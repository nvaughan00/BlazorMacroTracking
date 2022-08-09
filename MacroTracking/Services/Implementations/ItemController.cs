using MacroTracking.Models;

namespace MacroTracking.Services.Implementations
{
    public class ItemController
    {
        public ItemController() { }

        public List<Item> GetAllItems()
        {
            using (var x = new MacroTrackingContext())
            {
                var items =
                    x.Items
                    .SqlQuery("SELECT * FROM Item")
                    .ToList();

                return items;
            }
        }
    }
}
