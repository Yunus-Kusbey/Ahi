using Esnaf.Application.DTOs.Order;
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
        Task CreateOrder(OrderCreate model);
        Task UpdateOrder(OrderUpdate model);
        Task DeleteOrder(Guid id);
        Task<List<Address>> GetAllOrder(Guid uid);
        Task<Address> GetOrder(Guid uid);
    }
}
