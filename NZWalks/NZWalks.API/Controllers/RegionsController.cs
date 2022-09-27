using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("Regions")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;
        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        public IMapper Mapper { get; }

        [HttpGet]
        //public IActionResult GetAllRegions()
        //{
        //    var regions = new List<Region>()
        //    { 
        //        new Region
        //        { 
        //            Id = Guid.NewGuid(),
        //            Name = "Wellington",
        //            Code = "WLG",
        //            Area = 227755,
        //            Lat = -1.8822,
        //            Long = 299.88,
        //            Population = 500000
        //        },
        //        new Region
        //        {
        //            Id = Guid.NewGuid(),
        //            Name = "Auckland",
        //            Code = "AUCK",
        //            Area = 227755,
        //            Lat = -1.8822,
        //            Long = 299.88,
        //            Population = 500000
        //        },
        //    };

        //    return Ok(regions);

        //}
        public async  Task<IActionResult> GetAllRegions()
        {
            var regions = await regionRepository.GetAll();
            var regionsDTO = mapper.Map<List<Models.DTO.Region>>(regions);
            return Ok(regionsDTO);
        }
    }
}
