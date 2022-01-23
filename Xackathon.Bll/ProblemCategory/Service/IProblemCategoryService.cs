using Xackathon.Bll.Model;

namespace Xackathon.Bll.Service
{
    public interface IProblemCategoryService
    {
        public Task<ProblemCategoryDomainModel> GetById(long id);
        public Task<ProblemCategoryDomainModel> Delete(long id);
        public Task<ProblemCategoryDomainModel> Update(long id, ProblemCategoryDomainModel obj);
        public Task<ProblemCategoryDomainModel> Create(ProblemCategoryDomainModel obj);
        public IEnumerable<ProblemCategoryDomainModel> Get();
    }
}
