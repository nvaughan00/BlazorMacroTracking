using MacroTracking.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MacroTracking.Services.Implementations
{
    public class MacroTrackingContext : DbContext
    {
        public MacroTrackingContext() : base() 
        { 
        }


        public DbSet<Item> Items { get; set; }
    }
}
