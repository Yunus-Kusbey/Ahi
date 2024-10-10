using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services
{
    public interface ICartService
    {
        Task CreateCart(Address address);
        Task UpdateCart(Address address);
        Task DeleteCart(Guid uid);
        Task<Address> GetCart(Guid uid);
        Task<List<Address>> GetAllCart();
    }
}
