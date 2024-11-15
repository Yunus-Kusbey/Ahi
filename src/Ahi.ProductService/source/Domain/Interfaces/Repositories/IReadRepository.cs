
namespace Ahi.ProductService.source.Domain.Interfaces.Repositories
{
    public interface IReadRepository<S> 
        //where T : class
        where S : struct
    {
        //Hepsinin dönüşü T olmalı
        IQueryable GetAll();
        IQueryable GetWhere(S model);
        Task GetByIdAsync(S model);
    }
}
