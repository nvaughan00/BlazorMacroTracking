using MacroTracking.Contexts;
using MacroTracking.Interfaces;
using MacroTracking.Models;

namespace MacroTracking.Services
{
    public class MacroTrackingService : IMacroTrackingService
    {
        private readonly IConfiguration config;
        private readonly MacroTrackingContext context;

        public MacroTrackingService(IConfiguration config, MacroTrackingContext context)
        {
            this.config = config;
            this.context = context;
        }

        public List<Item> GetAllItems()
        {
            return context.Items.ToList();
        }
    }
}
