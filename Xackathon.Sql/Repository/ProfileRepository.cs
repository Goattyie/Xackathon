using Xackathon.Dal.Models;

namespace Xackathon.Sql.Repository
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly SqlContext _db;

        public ProfileRepository(SqlContext db)
        {
            _db = db;
        }
        public async Task Create(Profile obj)
        {
            await _db.AddAsync(obj);
            await _db.SaveChangesAsync();
        }

        public Task Delete(Profile obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Profile> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Profile> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Profile> GetByPhone(string phoneNumber)
        {
            var profile = _db.Profiles.FirstOrDefault(x => x.Phone == phoneNumber);
            return Task.FromResult(profile);
        }

        public Task Update(Profile obj)
        {
            throw new NotImplementedException();
        }
    }
}
