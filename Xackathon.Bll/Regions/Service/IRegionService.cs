using Xackathon.Bll.Model;

namespace Xackathon.Bll.Service
{
    public interface IRegionService
    {
        public Task<RegionDomainModel> GetById(long id);
        public Task<RegionDomainModel> Delete(long id);
        public Task<RegionDomainModel> Update(long id, RegionDomainModel role);
        public Task<RegionDomainModel> Create(RegionDomainModel role);
        public IEnumerable<RegionDomainModel> Get();
    }
}
