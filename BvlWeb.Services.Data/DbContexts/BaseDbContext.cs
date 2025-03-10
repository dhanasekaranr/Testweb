using Microsoft.EntityFrameworkCore;

namespace BvlWeb.Services.Data.DbContexts
{
    public abstract class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions options)
            : base(options)
        { }

        // Shared DbSet for a sample model. Add additional shared entities as needed.
        public DbSet<YourModel> YourModels { get; set; }
    }

    public class YourModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Other properties…
    }
}
