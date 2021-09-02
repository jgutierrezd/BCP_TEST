using AutoMapper;
using BCP.Test.Api.Dtos;
using BCP.Test.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace BCP.Test.Api.Controllers
{
    [Authorize(Roles = "ADMIN")]
    [Route("api/[controller]")]
    [ApiController]
    public class RatesController : ControllerBase
    {
        private readonly ILogger<RatesController> _logger;
        private readonly IRateService _baseService;
        private readonly IMapper _mapper;
        public RatesController(ILogger<RatesController> logger, IRateService baseService, IMapper mapper)
        {
            _logger = logger;
            _baseService = baseService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<Object> Create([FromBody] RateDto newEntity)
        {
            var entityModel = _mapper.Map<Models.Rate>(newEntity);

            var entityResult = await _baseService.Create(entityModel);
            if (entityResult == null)
                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating new record");

            return Created(Url.RouteUrl(new { action = nameof(Get), idEntity = entityResult.Id }), entityResult);
        }

        [HttpGet("{idEntity}")]
        public async Task<Object> Get(int idEntity)
        {
            var currentEntity = await _baseService.GetById(idEntity);
            if (currentEntity == null)
                return NotFound();

            return Ok(currentEntity);
        }
    }
}
