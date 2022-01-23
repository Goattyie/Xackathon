using Xackathon.Bll.Model;

namespace Xackathon.Bll.Service
{
    public interface IStoryService
    {
        public Task<StoryDomainModel> GetById(long id);
        public Task<StoryDomainModel> Delete(long id);
        public Task<StoryDomainModel> Update(long id, StoryDomainModel obj);
        public Task<StoryDomainModel> Create(StoryDomainModel obj);
        public Task<StoryDomainModel> Watch(long id);
        public IEnumerable<StoryDomainModel> Get();
    }
}
