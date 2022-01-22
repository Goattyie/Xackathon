using Xackathon.Dal.Models;

namespace Xackathon.Sql.Repository
{
    public class RegionRepository : IRepository<Region>
    {
        private readonly SqlContext _db;

        public RegionRepository(SqlContext db)
        {
            _db = db;
        }
        public async Task Create(Region obj)
        {
            await _db.Regions.AddAsync(obj);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Region obj)
        {
            _db.Regions.Remove(obj);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<Region> Get()
        {
            return _db.Regions;
        }

        public async Task<Region> GetById(long id)
        {
            var entity = await _db.Regions.FindAsync(id);
            if (entity != null)
                _db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Detached;

            return entity;
        }

        public async Task Update(Region obj)
        {
            _db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.Regions.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}
