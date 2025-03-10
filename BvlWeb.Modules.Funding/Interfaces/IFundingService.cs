using BvlWeb.Modules.Funding.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BvlWeb.Modules.Funding.Interfaces
{
    public interface IFundingService
    {
        //FundingDto GetFunding(int id, string? dbType = null);
        FundingDto GetFunding(int id);
    }
}
