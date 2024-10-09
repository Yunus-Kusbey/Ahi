using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services
{
    public interface IAddressService
    {
        Task CreateAddress(Address address);
        Task UpdateAddress(Address address);
        Task DeleteAddress(Guid uid);
        Task<Address> GetAddress(Guid uid);
        Task<List<Address>> GetAllAddresses();

    }
}
