using NZWalks.Models.Domina;

namespace NZWalks.Repository
{
    public interface IRegionsRepository
    {
        public Task<IEnumerable<Region>> GetAllRegionAsync();
        public Region GetRegionByID();
        public void CreateRegion();
        public Region UpdateRegion();
        public void DeleteRegion();



    }
}
