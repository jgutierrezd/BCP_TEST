using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCP.Test.Api.Data
{
    public static class SeedCreator
    {
        public static void CreateData(TestDbContext dbContext)
        {
            dbContext.Rates.Add(new Models.Rate { CurrencyOrigin = "PEN", rate = 4.1m, CurrencyDestiny = "USD", IsMultiplier = false });
            dbContext.Rates.Add(new Models.Rate { CurrencyOrigin = "USD", rate = 3.9m, CurrencyDestiny = "PEN", IsMultiplier = true });
        }
    }
}
