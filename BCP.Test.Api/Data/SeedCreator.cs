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
            dbContext.ExchangeRates.Add(new Models.ExchangeRate { Id = 1, date = DateTime.Now.Date, rate = 4.1m });
        }
    }
}
