using Xackathon.Bll.Model;
using Xackathon.Dal.Models;
using Xackathon.Sql.Repository;

namespace Xackathon.Bll.Service
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _db;

        public RequestService(IRequestRepository db)
        {
            _db = db;
        }
        public async Task<RequestDomainModel> Create(RequestDomainModel obj)
        {
            var entity = (Request)obj;

            await _db.Create(entity);

            return entity.ToRequestDomain();
        }

        public async Task<RequestDomainModel> Delete(long id)
        {
            var entity = await _db.GetById(id);

            if (entity == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            await _db.Delete(entity);

            return entity.ToRequestDomain();
        }

        public IEnumerable<RequestDomainModel> Get()
        {
            var list = _db.Get();

            return list.ToRequestDomainArray();
        }

        public async Task<RequestDomainModel> GetById(long id)
        {
            var entity = await _db.GetById(id);

            if (entity == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            return entity.ToRequestDomain();
        }

        public async Task<RequestDomainModel> Update(long id, RequestDomainModel obj)
        {
            var entity = await _db.GetById(id);

            if (entity == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            obj.Id = id;
            var updateEntity = (Request)obj;

            await _db.Update(updateEntity);

            return updateEntity.ToRequestDomain();
        }
    }
}
