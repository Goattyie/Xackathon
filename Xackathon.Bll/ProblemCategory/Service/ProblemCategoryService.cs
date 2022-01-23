using Xackathon.Bll.Model;
using Xackathon.Dal.Models;
using Xackathon.Sql.Repository;

namespace Xackathon.Bll.Service
{
    public class ProblemCategoryService : IProblemCategoryService
    {
        private readonly IProblemCategoryRepository _db;

        public ProblemCategoryService(IProblemCategoryRepository db)
        {
            _db = db;
        }
        public async Task<ProblemCategoryDomainModel> Create(ProblemCategoryDomainModel obj)
        {
            var entity = (ProblemCategory)obj;

            await _db.Create(entity);

            return entity.ToProblemCategoryDomain();
        }

        public async Task<ProblemCategoryDomainModel> Delete(long id)
        {
            var entity = await _db.GetById(id);

            if (entity == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            await _db.Delete(entity);

            return entity.ToProblemCategoryDomain();
        }

        public IEnumerable<ProblemCategoryDomainModel> Get()
        {
            var entities = _db.Get();

            return entities.ToProblemCategoryDomainArray();
        }

        public async Task<ProblemCategoryDomainModel> GetById(long id)
        {
            var entity = await _db.GetById(id);

            return entity.ToProblemCategoryDomain();
        }

        public async Task<ProblemCategoryDomainModel> Update(long id, ProblemCategoryDomainModel obj)
        {
            var entity = await _db.GetById(id);

            if (entity == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            obj.Id = id;
            var updateEntity = (ProblemCategory)obj;

            await _db.Update(updateEntity);

            return updateEntity.ToProblemCategoryDomain();
        }
    }
}
