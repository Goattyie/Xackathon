using Xackathon.Bll.Model;
using Xackathon.Dal.Models;
using Xackathon.Sql.Repository;

namespace Xackathon.Bll.Service
{
    public class StoryService : IStoryService
    {
        private IRepository<Story> _db;

        public StoryService(IRepository<Story> db)
        {
            _db = db;
        }
        public async Task<StoryDomainModel> Create(StoryDomainModel obj)
        {
            var entity = (Story)obj;
            
            await _db.Create(entity);

            return entity.ToStoryDomain();
        }

        public async Task<StoryDomainModel> Delete(long id)
        {
            var entity = await _db.GetById(id);

            if(entity == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            await _db.Delete(entity);

            return entity.ToStoryDomain();
        }

        public IEnumerable<StoryDomainModel> Get()
        {
            return _db.Get().ToStoryDomainArray();
        }

        public async Task<StoryDomainModel> GetById(long id)
        {
            var entity = await _db.GetById(id);
            return entity.ToStoryDomain();
        }

        public async Task<StoryDomainModel> Update(long id, StoryDomainModel obj)
        {
            var entity = await _db.GetById(id);

            if (entity == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            obj.Id = id;
            var updateEntity = (Story)obj;

            await _db.Update(updateEntity);

            return updateEntity.ToStoryDomain();
        }

        public async Task<StoryDomainModel> Watch(long id)
        {
            var entity = await _db.GetById(id);

            if (entity == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            entity.WatchCount += 1;

            await _db.Update(entity);

            return entity.ToStoryDomain();
        }
    }
}
