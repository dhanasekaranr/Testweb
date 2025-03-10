using Microsoft.EntityFrameworkCore;
using BvlWeb.Services.Data.Entities;

namespace BvlWeb.Services.Data.DbContexts
{
    public class SecondOracleDbContext : BaseDbContext
    {
        public SecondOracleDbContext(DbContextOptions<SecondOracleDbContext> options)
            : base(options)
        { }
    }
}
