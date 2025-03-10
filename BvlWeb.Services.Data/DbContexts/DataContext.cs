using Microsoft.EntityFrameworkCore;
using BvlWeb.Services.Data.Entities;

namespace BvlWeb.Services.Data.DbContexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        public DbSet<LoanEntity> Loans { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply configurations here or via separate configuration classes
            base.OnModelCreating(modelBuilder);
        }
    }
}
