using Microsoft.EntityFrameworkCore;
using BvlWeb.Services.Data.Entities;

namespace BvlWeb.Services.Data.DbContexts
{
    public class FirstOracleDbContext : BaseDbContext
    {
        public FirstOracleDbContext(DbContextOptions<FirstOracleDbContext> options)
            : base(options)
        { }
    }
}
