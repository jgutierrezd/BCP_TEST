using BCP.Test.Api.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCP.Test.Api.Services
{
    public interface IExchangeService
    {
        Task<ExchangeResultDto> GenerateExchange(decimal amount,string origin, string destiny, string email);
    }
}
