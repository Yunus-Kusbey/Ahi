namespace Esnaf.Application.Repositories
{
    public interface IReadRepository<T>  where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere();
        Task<T> GetByIdAsync(string name);
    }
}
