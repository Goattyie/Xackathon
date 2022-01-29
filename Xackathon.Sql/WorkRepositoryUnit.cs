using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xackathon.Sql.Repository;

namespace Xackathon.Sql
{
    public class WorkRepositoryUnit
    {
        private readonly SqlContext _db;
        public WorkRepositoryUnit(SqlContext db, IProblemCategoryRepository pcr, IRequestRepository rr, IProfileRepository pr)
        {
            _db = db;
            ProblemCategory = pcr;
            Request = rr;
            Profile = pr;
        }

        public IProblemCategoryRepository ProblemCategory { get; set; }
        public IRequestRepository Request { get; set; }
        public IProfileRepository Profile { get; set; }
        public async Task SaveAsync() => await _db.SaveChangesAsync();
    }
}
