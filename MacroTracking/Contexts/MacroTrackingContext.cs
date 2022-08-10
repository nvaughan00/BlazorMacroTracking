using MacroTracking.Models;
using Microsoft.EntityFrameworkCore;

namespace MacroTracking.Contexts
{
    public partial class MacroTrackingContext : DbContext
    {
        public virtual DbSet<Item> Items { get ; set; }

        public MacroTrackingContext()
        {
            Database.SetCommandTimeout(600);
        }

        public MacroTrackingContext(DbContextOptions<MacroTrackingContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:MacroTrackingDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>(entity =>
                {
                    entity.HasKey(x => x.Id);

                    entity.ToTable("ITEM", "dbo");


                }
            );
        }

    }
}
