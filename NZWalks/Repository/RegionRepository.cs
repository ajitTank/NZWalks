using Microsoft.EntityFrameworkCore;
using NZWalks.Data;
using NZWalks.Models.Domina;

namespace NZWalks.Repository
{
    public class RegionRepository : IRegionsRepository
    {
        private readonly ApplicationDb applicationDb;

        public RegionRepository(ApplicationDb applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public void CreateRegion()
        {
            throw new NotImplementedException();
        }

        public void DeleteRegion()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Region>> GetAllRegionAsync()
        {
          return await this.applicationDb.Regions.ToListAsync();
        }

        public Region GetRegionByID()
        {
            throw new NotImplementedException();
        }

        public Region UpdateRegion()
        {
            throw new NotImplementedException();
        }
    }
}
