using BCP.Test.Api.Dtos;
using BCP.Test.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace BCP.Test.Api.Controllers
{
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

        [HttpPost]
        public Object Procesar([FromBody] ExchangeDto newEntity)
        {
            return Ok(true);
        }
    }
}
