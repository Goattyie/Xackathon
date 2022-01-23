using Microsoft.EntityFrameworkCore;
using Xackathon.Dal.Models;

namespace Xackathon.Sql.Repository
{
    public class UserRepository : IRepository<User>
    {
        private readonly SqlContext _db;

        public UserRepository(SqlContext db)
        {
            _db = db;
        }
        public async Task Create(User obj)
        {
            await _db.AddAsync(obj);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(User obj)
        {
            _db.Remove(obj);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<User> Get()
        {
            return _db.Users.Include(x => x.Profile);
        }

        public async Task<User> GetById(long id)
        {
            var entity = await _db.Users.Include(x => x.Profile).FirstOrDefaultAsync(x=>x.Id == id);

            if (entity != null)
                _db.Entry(entity).State = EntityState.Detached;

            return entity;
        }
        public async Task Update(User obj)
        {
            _db.Users.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}
