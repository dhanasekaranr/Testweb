using BvlWeb.Modules.Funding.Repositories;
using BvlWeb.Modules.Funding.Models.Dto;
using BvlWeb.Services.Common.Base;
using Microsoft.Extensions.Logging;
using BvlWeb.Modules.Funding.Interfaces;
using BvlWeb.Services.Data.DbContexts;

namespace BvlWeb.Modules.Funding.Services
{
    public class FundingService: BaseService, IFundingService
    {
        private readonly FundingRepository _repository;

        

        public FundingService(FundingRepository repository, IDbContextFactory dbContextFactory, ILogger<FundingService> logger)
            : base(dbContextFactory, logger)
        {
            _repository = repository;
        }

        public FundingDto GetFunding(int id)
        {
            // Optionally use the correct DbContext if the repository depends on it.
            var context = GetDbContext();
            // For demo purposes, simply call the repository method.
            return _repository.GetById(id);
        }
    }
}
