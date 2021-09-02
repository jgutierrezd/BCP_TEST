using System;
using AutoMapper;
using BCP.Test.Api.Dtos;

namespace BCP.Test.Api.Helpers
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<RateDto, Models.Rate>();
        }
    }
}
