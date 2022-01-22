using Xackathon.Bll.Service;
using Xackathon.Sql;

namespace Xackathon.Bll
{
    public class Services
    {
        private readonly SqlContext _db;
        public Services(IRoleService role, SqlContext db)
        {
            _db = db;
            RoleService = role;
        }


        public IRoleService RoleService { get; }
        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
