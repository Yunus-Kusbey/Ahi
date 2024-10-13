using Esnaf.Application.DTOs.Address;
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
        Task Create(AddressCreate model);
        Task Update(AddressUpdate model);
        Task Delete(Guid uid);
        Task<Address> Get(Guid uid);
        Task<List<Address>> GetAllAddresses(Guid uid);

    }
}
