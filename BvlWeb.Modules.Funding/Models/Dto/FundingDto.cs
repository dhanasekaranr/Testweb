﻿using BvlWeb.Services.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BvlWeb.Modules.Funding.Models.Dto
{
    public class FundingDto: BasePageDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
