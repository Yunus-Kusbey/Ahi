using Esnaf.Application.DTOs.Customer;
using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services
{
    public interface ICustomerService
    {
        Task CreateCustomer(CustomerCreate model);
        Task UpdateCustomer(CustomerUpdate model);
        Task DeleteCustomer(Guid uid);
        Task<Address> GetCustomer(Guid uid);
    }
}
