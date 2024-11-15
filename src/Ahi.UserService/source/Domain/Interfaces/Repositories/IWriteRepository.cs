namespace Ahi.UserService.source.Domain.Interfaces.Repositories
{
    public interface IWriteRepository<C,U,T> 
        where C :class
        where U :class
        where T : struct 
        
    {
        Task<T> AddAsync(C model);
        bool Remove(T model);
        Task<bool> RemoveAsync(T model);
        Task<bool> UpdateAsync(U model);
    }
}
