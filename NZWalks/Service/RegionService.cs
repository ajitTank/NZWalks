using NZWalks.Models.Domina;
using NZWalks.Repository;

namespace NZWalks.Service
{
    public class RegionService
    {
        private readonly IRegionsRepository regionsRepository;

        public RegionService(IRegionsRepository regionsRepository)
        {
            this.regionsRepository = regionsRepository;
        }


        public async Task<IEnumerable<Region>> GetAllRegionsAsync()
        {
           return await this.regionsRepository.GetAllRegionAsync();
        }
    }
}
