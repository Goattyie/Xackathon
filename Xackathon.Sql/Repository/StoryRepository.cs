using Xackathon.Dal.Models;

namespace Xackathon.Sql.Repository
{
    public class StoryRepository : IRepository<Story>
    {
        private readonly SqlContext _db;

        public StoryRepository(SqlContext db)
        {
            _db = db;
        }
        public async Task Create(Story obj)
        {
            await _db.AddAsync(obj);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Story obj)
        {
            _db.Remove(obj);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<Story> Get()
        {
            return _db.Stories;
        }

        public async Task<Story> GetById(long id)
        {
            var entity = await _db.Stories.FindAsync(id);

            if (entity != null)
                _db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Detached;

            return entity;
        }

        public async Task Update(Story obj)
        {
            _db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.Stories.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}
