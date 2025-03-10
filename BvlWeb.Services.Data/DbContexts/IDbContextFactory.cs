using Microsoft.EntityFrameworkCore;
using BvlWeb.Services.Data.Entities;

namespace BvlWeb.Services.Data.DbContexts
{
    public interface IDbContextFactory
    {
        BaseDbContext CreateDbContext();
    }
}
