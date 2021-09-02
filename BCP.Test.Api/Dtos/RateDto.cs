using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCP.Test.Api.Dtos
{
    public class RateDto
    {
        public string CurrencyOrigin { get; set; }
        public string CurrencyDestiny { get; set; }
        public decimal Rate { get; set; }
        public bool IsMultiplier { get; set; }
    }
}
