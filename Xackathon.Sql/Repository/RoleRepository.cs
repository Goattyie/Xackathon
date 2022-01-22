using Microsoft.EntityFrameworkCore;
using Xackathon.Dal.Models;

namespace Xackathon.Sql.Repository
{
    public class RoleRepository : IRepository<Role>
    {
        private readonly SqlContext _db;

        public RoleRepository(SqlContext db)
        {
            _db = db;
        }
        public async Task Create(Role obj)
        {
            await _db.Roles.AddAsync(obj);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Role obj)
        {
            _db.Roles.Remove(obj);
            await _db.SaveChangesAsync(); 
        }

        public IEnumerable<Role> Get()
        {
            return _db.Roles;
        }

        public async Task<Role> GetById(long id)
        {
            var item = await _db.Roles.FindAsync(id);
            if(item != null)
                _db.Entry(item).State = EntityState.Detached;
            return item;
        }

        public async Task Update(Role obj)
        {
            _db.Entry(obj).State = EntityState.Modified;
            _db.Roles.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}
