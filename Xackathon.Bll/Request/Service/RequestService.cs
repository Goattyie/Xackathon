using Xackathon.Bll.Model;
using Xackathon.Dal.Models;
using Xackathon.Sql;

namespace Xackathon.Bll.Service
{
    public class RequestService : IRequestService
    {
        private readonly WorkRepositoryUnit _db;

        public RequestService(WorkRepositoryUnit db)
        {
            _db = db;
        }
        public async Task<RequestDomainModel> Create(RequestFormDomainModel obj)
        {
            var profile = (Profile)obj;
            var request = (Request)obj;
            var categories = new List<ProblemCategory>();

            foreach(var id in obj.ProblemCategories)
            {
                var problem = await _db.ProblemCategory.GetById(id);

                if (problem == null)
                    throw new Exception(Resources.Errors.ObjectNotFound + $": problemId {id}");

                problem.Requests = new List<Request> { request };
                categories.Add(problem);
            }
            foreach(var problem in categories)
            {
                await _db.ProblemCategory.Update(problem);
            }

            if((await _db.Profile.GetByPhone(profile.Phone)) == null)
            {
                await _db.Profile.Create(profile);
            }

            request.Profile = profile;
            await _db.Request.Create(request);

            return request.ToRequestDomain();
        }

        public async Task<RequestDomainModel> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RequestDomainModel> Get()
        {
            return _db.Request.Get().ToRequestDomainArray();
        }

        public async Task<RequestDomainModel> GetById(long id)
        {
            var domain = await _db.Request.GetById(id);
            return domain.ToRequestDomain();
        }

        public async Task<RequestDomainModel> Update(long id, RequestDomainModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
