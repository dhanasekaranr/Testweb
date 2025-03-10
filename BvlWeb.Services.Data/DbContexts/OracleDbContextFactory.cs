using Microsoft.EntityFrameworkCore;
using BvlWeb.Services.Data.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using System;

namespace BvlWeb.Services.Data.DbContexts
{
    public class OracleDbContextFactory : IDbContextFactory
    {
        private readonly IServiceProvider _serviceProvider;

        private readonly IHttpContextAccessor _httpContextAccessor;

        public OracleDbContextFactory(IServiceProvider serviceProvider, IHttpContextAccessor httpContextAccessor)
        {
            _serviceProvider = serviceProvider;
            _httpContextAccessor = httpContextAccessor;
        }

        public BaseDbContext CreateDbContext()
        {
            // Retrieve the "SelectedDb" value set by the middleware.
            var context = _httpContextAccessor.HttpContext;
            var dbParam = context?.Items["SelectedDb"]?.ToString() ?? "first";

            if (dbParam.Equals("first", StringComparison.OrdinalIgnoreCase))
            {
                return _serviceProvider.GetRequiredService<FirstOracleDbContext>();
            }
            else if (dbParam.Equals("second", StringComparison.OrdinalIgnoreCase))
            {
                return _serviceProvider.GetRequiredService<SecondOracleDbContext>();
            }
            else
            {
                // Default fallback
                return _serviceProvider.GetRequiredService<FirstOracleDbContext>();
            }
        }
    }
}
