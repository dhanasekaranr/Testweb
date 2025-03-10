using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BvlWeb.Services.Common.Middleware
{

    public class DbContextSelectionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<DbContextSelectionMiddleware> _logger;

        public DbContextSelectionMiddleware(RequestDelegate next, ILogger<DbContextSelectionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Read the "db" query parameter; default to "first" if missing.
            var dbParam = context.Request.Query["db"].ToString();
            if (string.IsNullOrWhiteSpace(dbParam))
            {
                dbParam = "first";
            }
            context.Items["SelectedDb"] = dbParam;
            _logger.LogInformation("Selected DbContext: {dbParam}", dbParam);

            await _next(context);
        }
    }
}
