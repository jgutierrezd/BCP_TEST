using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCP.Test.Api.Models
{
    public class Rate
    {
        public int Id { get; set; }
        public string CurrencyOrigin { get; set; }
        public string CurrencyDestiny { get; set; }
        public decimal rate { get; set; }
        public bool IsMultiplier  { get; set; }
    }
}
