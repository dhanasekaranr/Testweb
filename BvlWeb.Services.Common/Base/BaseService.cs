using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BvlWeb.Services.Data.DbContexts;
using Microsoft.Extensions.Logging;

namespace BvlWeb.Services.Common.Base
{
    public abstract class BaseService
    {
        protected readonly IDbContextFactory DbContextFactory;
        protected readonly ILogger Logger;

        protected BaseService(IDbContextFactory dbContextFactory, ILogger logger)
        {
            DbContextFactory = dbContextFactory;
            Logger = logger;
        }

        protected BaseDbContext GetDbContext() => DbContextFactory.CreateDbContext();
    }
}
