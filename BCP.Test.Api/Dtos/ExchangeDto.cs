using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCP.Test.Api.Dtos
{
    public class ExchangeDto
    {
        public decimal Amount { get; set; }
        public string OriginCurrency { get; set; }
        public string DestinationCurrency { get; set; }

        public string Email { get; set; }
    }
}
