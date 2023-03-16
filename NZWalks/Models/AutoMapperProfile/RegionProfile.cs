using AutoMapper;
using NZWalks.Models.Domina;
using NZWalks.Models.DTO;

namespace NZWalks.Models.AutoMapperProfile
{
    public class RegionProfile:Profile
    {
        public RegionProfile()
        {
            /*CreateMap<source,Destination>()*/


            /*
             ex:- 
              CreateMap<Region, RegionDTO>();
                or 
            if name are not same then
               CreateMap<Region, RegionDTO>()
                    .ForMember(des=>des.populationOfRegion,option=>option.MapFrom(src=>src.population)) ;
             */


            CreateMap<Region,RegionDTO>().ReverseMap();

        }

        
    }
}
