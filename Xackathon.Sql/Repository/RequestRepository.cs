using Microsoft.EntityFrameworkCore;
using Xackathon.Dal.Models;

namespace Xackathon.Sql.Repository
{
    public class RequestRepository : IRequestRepository
    {
        private readonly SqlContext _db;

        public RequestRepository(SqlContext db)
        {
            _db = db;
        }
        public async Task Create(Request obj)
        {
            await _db.Requests.AddAsync(obj);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Request obj)
        {
            _db.Requests.Remove(obj);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<Request> Get()
        {
            return _db.Requests.Include(x => x.Profile).Include(x => x.ProblemCategories);
        }

        public async Task<Request> GetById(long id)
        {
            var entity = await _db.Requests.Include(x=>x.Profile).Include(x=>x.ProblemCategories).FirstOrDefaultAsync(x=>x.Id == id);

            if (entity != null)
                _db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Detached;

            return entity;
        }

        public async Task Update(Request obj)
        {
            _db.Requests.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}
