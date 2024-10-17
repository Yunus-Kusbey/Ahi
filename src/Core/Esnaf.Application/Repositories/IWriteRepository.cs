namespace Esnaf.Application.Repositories
{
    public interface IWriteRepository<A, U,K>
        where A : class
        where U : class
        where K : struct
    {
        Task<K> AddAsync(A model);
        bool Delete(Guid id);
        Task<bool> DeleteAsync(Guid id);
        bool Update(U model);

    }
}
