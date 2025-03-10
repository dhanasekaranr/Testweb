using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BvlWeb.Services.Data.Entities
{
    public class LoanEntity
    {
        public int Id { get; set; }
        public string LoanName { get; set; }
        public decimal Amount { get; set; }
    }
}
