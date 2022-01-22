using Xackathon.Bll.Model;
using Xackathon.Dal.Models;
using Xackathon.Sql.Repository;

namespace Xackathon.Bll.Service
{
    public class RegionService : IRegionService
    {
        private readonly IRepository<Region> _db;

        public RegionService(IRepository<Region> db)
        {
            _db = db;
        }
        public async Task<RegionDomainModel> Create(RegionDomainModel role)
        {
            var entity = (Region)role;
            await _db.Create(entity);
            return DomainHelper.ToRegionDomain(entity);
        }

        public async Task<RegionDomainModel> Delete(long id)
        {
            var entity = await _db.GetById(id);

            if (entity == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            await _db.Delete(entity);

            return entity.ToRegionDomain();
        }

        public IEnumerable<RegionDomainModel> Get()
        {
            return _db.Get().ToRegionDomainArray();
        }

        public async Task<RegionDomainModel> GetById(long id)
        {
            var entity = await _db.GetById(id);

            if (entity == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            return entity.ToRegionDomain();
        }

        public async Task<RegionDomainModel> Update(long id, RegionDomainModel role)
        {
            var regionEntity = await _db.GetById(id);

            if (regionEntity == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            role.Id = id;
            regionEntity = (Region)role;

            await _db.Update(regionEntity);

            return regionEntity.ToRegionDomain();
        }
    }
}
