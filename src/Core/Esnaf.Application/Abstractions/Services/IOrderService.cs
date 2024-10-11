using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services
{
    public interface IOrderService
    {
        Task CreateOrder(Address address);
        Task UpdateStatusOrder(Address address);
        Task CancelOrder(Address address);
        Task<List<Address>> GetAllOrder(Guid uid);
        Task<Address> GetOrder(Guid uid);
    }
}
