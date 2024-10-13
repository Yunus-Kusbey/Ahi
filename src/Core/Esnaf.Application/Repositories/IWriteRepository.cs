namespace Esnaf.Application.Repositories
{
    public interface IWriteRepository<A, U>
        where A : class
        where U : class
    {
        Task<bool> AddAsync(A model);
        bool Delete(Guid id);
        Task<bool> DeleteAsync(Guid id);
        bool Update(U model);

    }
}
