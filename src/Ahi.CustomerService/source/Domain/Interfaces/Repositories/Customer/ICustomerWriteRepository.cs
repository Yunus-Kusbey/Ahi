
using Ahi.CustomerService.source.Application.DTOs.Customer;

namespace Ahi.CustomerService.source.Domain.Interfaces.Repositories
{
    public interface ICustomerWriteRepository : IWriteRepository<CustomerCreateDTO, CustomerUpdateDTO, Guid>
    {
    }
}
