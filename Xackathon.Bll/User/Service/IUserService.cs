using Xackathon.Bll.Model;

namespace Xackathon.Bll.Service
{
    public interface IUserService
    {
        public Task<UserDomainModel> GetById(long id);
        public Task<UserDomainModel> Delete(long id);
        public Task<UserDomainModel> Update(long id, UserDomainModel obj);
        public Task<UserDomainModel> Create(UserDomainModel obj);
        public IEnumerable<UserDomainModel> GetBlocked();
        public IEnumerable<UserDomainModel> GetUnblocked();
        public IEnumerable<UserDomainModel> Get();
        public Task<ProfileDomainModel> GetProfile(long userId);
    }
}
