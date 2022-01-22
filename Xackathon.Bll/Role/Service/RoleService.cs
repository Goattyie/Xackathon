using Xackathon.Bll.Model;
using Xackathon.Dal.Models;
using Xackathon.Sql.Repository;

namespace Xackathon.Bll.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRepository<Role> _db;

        public RoleService(IRepository<Role> db)
        {
            _db = db;
        }

        public async Task<RoleDomainModel> Create(RoleDomainModel role)
        {
            var modelRole = (Role)role;

            await _db.Create(modelRole);

            return modelRole.ToRoleDomain();
        }

        public async Task<RoleDomainModel> DeleteRole(long id)
        {
            var role = await _db.GetById(id);

            if (role == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            await _db.Delete(role);

            return role.ToRoleDomain();
        }

        public IEnumerable<RoleDomainModel> Get()
        {
            var roles = _db.Get();
            return roles.ToRoleDomainArray();
        }

        public async Task<RoleDomainModel> GetRole(long id)
        {
            var role = await _db.GetById(id);

            return role != null ? role.ToRoleDomain() : throw new Exception(Resources.Errors.ObjectNotFound);
        }

        public async Task<RoleDomainModel> UpdateRole(long id, RoleDomainModel roleDomain)
        {
            var roleModel = await _db.GetById(id);

            if (roleModel == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            roleDomain.Id = id;
            roleModel = (Role)roleDomain;

            await _db.Update(roleModel);

            return roleModel.ToRoleDomain();
        }
    }
}
