using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCP.Test.Api.Models
{
    public class ExchangeRate
    {
        public int Id { get; set; }
        public decimal rate { get; set; }

        public DateTime date { get; set; }
    }
}
