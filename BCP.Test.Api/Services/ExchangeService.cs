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
        private readonly decimal _discount;

        public ExchangeService(TestDbContext dbContext)
        {
            _dbContext = dbContext;
            _discount = 0.04m;
        }

        public async Task<ExchangeResultDto> GenerateExchange(decimal amount, string origin, string destiny, string email)
        {
            var objRate = await _dbContext.Rates.Where(a => a.CurrencyOrigin == origin && a.CurrencyDestiny == destiny).FirstOrDefaultAsync();
            if (objRate == null) return null;

            var valueRate = objRate.rate;

            var objPrefer = await _dbContext.Prefers.Where(x => x.Email == email).FirstOrDefaultAsync();
            if (objPrefer != null)
            {
                valueRate = objRate.IsMultiplier ? objRate.rate + _discount : objRate.rate - _discount;
            }

            var amountExchange = objRate.IsMultiplier ? amount * valueRate : amount / valueRate;

            return new ExchangeResultDto { Amount = amount, AmountExchange = amountExchange, DestinationCurrency = destiny, OriginCurrency = origin, Rate = valueRate };
        }
    }
}
