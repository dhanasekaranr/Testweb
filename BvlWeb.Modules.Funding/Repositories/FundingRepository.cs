using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BvlWeb.Modules.Funding.Models.Dto;

namespace BvlWeb.Modules.Funding.Repositories
{
    public class FundingRepository
    {
        // Dummy implementation; replace with real data access
        public FundingDto GetById(int id)
        {
            return new FundingDto { Id = id, Name = "Sample Funding" };
        }
    }
}
