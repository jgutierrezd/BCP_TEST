using BCP.Test.Api.Dtos;
using BCP.Test.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace BCP.Test.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangesController : ControllerBase
    {
        private readonly ILogger<ExchangesController> _logger;
        private readonly IExchangeService _baseService;
        public ExchangesController(ILogger<ExchangesController> logger, IExchangeService baseService)
        {
            _logger = logger;
            _baseService = baseService;
        }

        [HttpPost("Process")]
        public async Task<Object> Procesar([FromBody] ExchangeDto newEntity)
        {
            var currentEntity = await _baseService.GenerateExchange(newEntity.Amount, newEntity.OriginCurrency, newEntity.DestinationCurrency, newEntity.Email);
            if (currentEntity == null)
                return NotFound();

            return Ok(currentEntity);
        }
    }
}
