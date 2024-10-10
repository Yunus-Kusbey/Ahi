namespace Esnaf.Application.Repositories
{
    public interface IWriteRepository<T>:IRepository <T> where T : class
    {
        Task<bool> AddAsync(T entity);
        bool Delete(T id);
        Task<bool> DeleteAsync(T id);
        bool Update(T entity);

    }
}
