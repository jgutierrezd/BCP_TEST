using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCP.Test.Api.Dtos
{
    public class ExchangeResultDto
    {
        public decimal Amount { get; set; }
        public string OriginCurrency { get; set; }
        public string DestinationCurrency { get; set; }

        public decimal AmountExchange { get; set; }

        public decimal Rate { get; set; }
    }
}
