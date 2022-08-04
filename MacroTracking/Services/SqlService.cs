using MacroTracking.Models;
using Microsoft.EntityFrameworkCore;

namespace MacroTracking.Services
{
    public partial class SqlService : DbContext
    {
        public SqlService() : base()
        {
        }

        public virtual DbSet<Item> Items { get; set; }


    }
}
