using Xackathon.Dal.Models;

namespace Xackathon.Sql.Repository
{
    public interface IProblemCategoryRepository : IRepository<ProblemCategory>
    {
        public IEnumerable<ProblemCategory> GetActiveRequests();
        public IEnumerable<ProblemCategory> GetCompletedRequests();
        public IEnumerable<ProblemCategory> GetArchiveRequests();
    }
}
