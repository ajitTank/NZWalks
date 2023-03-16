using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.Models.AutoMapperProfile;
using NZWalks.Models.Domina;
using NZWalks.Models.DTO;
using NZWalks.Service;

namespace NZWalks.Controllers
{
    [ApiController]
    [Route("api/NZ-Region")]
/*    [Route("api/[controller]")]*/
    public class RegionController : ControllerBase
    {
        private readonly RegionService regionService;
        private readonly IMapper mapper;

        public RegionController(RegionService regionService, IMapper mapper )
        {
            this.regionService = regionService;
            this.mapper = mapper;
        }
        [HttpGet("RegionGetAll")]
        public async Task<IActionResult> GetAllRegions()
        {
           var listOfRegions = await this.regionService.GetAllRegionsAsync();
            var regions = new List<Region>()
            {
                new Region(){Id=Guid.NewGuid(),
                            Code="wellingoton",
                            Area=12324,
                            Lat=1213,
                            Long=223,
                            population=2323,            
                },
                new Region(){Id=Guid.NewGuid(),
                            Code="Us",
                            Area=24,
                            Lat=113,
                            Long=23,
                            population=23212323,
                },
            };

            /*   var RegionDTOList =   new List<RegionDTO>();
                  foreach (var region in listOfRegions)
                  {
                      var RegionDTO = new RegionDTO()
                      {
                          Id = region.Id,
                          Area = region.Area,
                          Code = region.Code
                      };
                      RegionDTOList.Add(RegionDTO);
                  }*/

            /*we are using automapper */
           var result = this.mapper.Map<IEnumerable<RegionDTO>>(regions);

            return Ok(result);
        }
    }
}
