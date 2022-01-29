using Xackathon.Dal.Models;

namespace Xackathon.Sql.Repository
{
    public class ProblemCategoryRepository : IProblemCategoryRepository
    {
        private readonly SqlContext _db;

        public ProblemCategoryRepository(SqlContext db)
        {
            _db = db;
        }
        public async Task Create(ProblemCategory obj)
        {
            await _db.ProblemCategories.AddAsync(obj);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(ProblemCategory obj)
        {
            _db.ProblemCategories.Remove(obj);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<ProblemCategory> Get()
        {
            return _db.ProblemCategories;
        }

        public async Task<ProblemCategory> GetById(long id)
        {
            var entity = await _db.ProblemCategories.FindAsync(id);

            if(entity != null)
                _db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Detached;

            return entity;
        }

        public async Task Update(ProblemCategory obj)
        {
            _db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.ProblemCategories.Update(obj);
            await _db.SaveChangesAsync();
        }
    }
}
