using Xackathon.Bll.Model;
using Xackathon.Dal.Models;
using Xackathon.Sql.Repository;

namespace Xackathon.Bll.Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _db;

        public UserService(IRepository<User> db)
        {
            _db = db;
        }
        public async Task<UserDomainModel> Create(UserDomainModel obj)
        {
            var entity = (User)obj;

            await _db.Create(entity);

            return entity.ToUserDomain();
        }

        public async Task<UserDomainModel> Delete(long id)
        {
            var entity = await _db.GetById(id);

            if (entity == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            await _db.Delete(entity);

            return entity.ToUserDomain();
        }

        public IEnumerable<UserDomainModel> Get()
        {
            return _db.Get().ToUserDomainArray();
        }

        public IEnumerable<UserDomainModel> GetBlocked()
        {
            throw new NotImplementedException();
        }

        public async Task<UserDomainModel> GetById(long id)
        {
            var entity = await _db.GetById(id);

            if (entity == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            return entity.ToUserDomain();
        }

        public Task<ProfileDomainModel> GetProfile(long userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDomainModel> GetUnblocked()
        {
            throw new NotImplementedException();
        }

        public async Task<UserDomainModel> Update(long id, UserDomainModel obj)
        {
            var entity = await _db.GetById(id);

            if (entity == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            obj.Id = id;
            var newEntity = (User)obj;
            
            await _db.Update(newEntity);

            return newEntity.ToUserDomain();
        }
    }
}
