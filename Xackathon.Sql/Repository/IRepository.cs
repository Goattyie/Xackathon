namespace Xackathon.Sql.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        Task<T> GetById(long id);
        Task Delete(T obj);
        Task Update(T obj);
        Task Create(T obj);
    }
}
