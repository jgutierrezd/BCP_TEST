using BCP.Test.Api.Data;
using BCP.Test.Api.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCP.Test.Api.Services
{
    public class ExchangeService : IExchangeService
    {
        private readonly TestDbContext _dbContext;

        public ExchangeService(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ExchangeResultDto> GenerateExchange(decimal amount, string origin, string destiny)
        {
            var objRate = await _dbContext.Rates.Where(a => a.CurrencyOrigin == origin && a.CurrencyDestiny == destiny).FirstOrDefaultAsync();
            if (objRate == null) return null;

            var amountExchange = objRate.IsMultiplier ? amount * objRate.rate : amount / objRate.rate;

            return new ExchangeResultDto { Amount = amount, AmountExchange = amountExchange, DestinationCurrency = destiny, OriginCurrency = origin, Rate = objRate.rate };
        }

        public async Task<Models.Rate> GetRateChange(string origin, string destiny)
        {
            var _object = new Models.Rate { CurrencyOrigin = "PEN", rate = 4.1m, CurrencyDestiny = "USD", IsMultiplier = false };
            var obj = await _dbContext.Rates.AddAsync(_object);
            var result = await _dbContext.SaveChangesAsync();

            return await _dbContext.Rates.Where(a => a.CurrencyOrigin == origin && a.CurrencyDestiny == destiny).FirstOrDefaultAsync();
        }
    }
}
