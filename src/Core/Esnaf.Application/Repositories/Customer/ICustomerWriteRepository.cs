using Esnaf.Application.DTOs.Customer;
using Esnaf.Domain.Entities;

namespace Esnaf.Application.Repositories
{
    public interface ICustomerWriteRepository:IWriteRepository<CustomerCreate,CustomerUpdate>
    {
    }
}
