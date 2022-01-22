using Xackathon.Bll.Model;

namespace Xackathon.Bll.Service
{
    public interface IRoleService
    {
        public Task<RoleDomainModel> GetRole(long id);
        public Task<RoleDomainModel> DeleteRole(long id);
        public Task<RoleDomainModel> UpdateRole(long id, RoleDomainModel role);
        public Task<RoleDomainModel> Create(RoleDomainModel role);
        public IEnumerable<RoleDomainModel> Get();

    }
}
