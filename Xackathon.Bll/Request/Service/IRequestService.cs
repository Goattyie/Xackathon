using Xackathon.Bll.Model;

namespace Xackathon.Bll.Service
{
    public interface IRequestService
    {
        public Task<RequestDomainModel> GetById(long id);
        public Task<RequestDomainModel> Delete(long id);
        public Task<RequestDomainModel> Update(long id, RequestDomainModel obj);
        public Task<RequestDomainModel> Create(RequestFormDomainModel obj);
        public IEnumerable<RequestDomainModel> Get();
    }
}
