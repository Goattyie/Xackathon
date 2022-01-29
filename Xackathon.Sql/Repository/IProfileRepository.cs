using Xackathon.Dal.Models;

namespace Xackathon.Sql.Repository
{
    public interface IProfileRepository : IRepository<Profile>
    {
        public Task<Profile> GetByPhone(string phoneNumber);
    }
}
