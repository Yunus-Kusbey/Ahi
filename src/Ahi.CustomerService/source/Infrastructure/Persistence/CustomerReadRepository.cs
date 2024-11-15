using Ahi.CustomerService.source.Domain.Interfaces.Repositories;

namespace Ahi.CustomerService.source.Infrastructure.Persistence
{
    public class CustomerReadRepository : ICustomerReadRepository
    {
        public IQueryable GetAll()
        {
            throw new NotImplementedException();
        }

        public Task GetByIdAsync(Guid model)
        {
            throw new NotImplementedException();
        }

        public IQueryable GetWhere(Guid model)
        {
            throw new NotImplementedException();
        }
    }
}
