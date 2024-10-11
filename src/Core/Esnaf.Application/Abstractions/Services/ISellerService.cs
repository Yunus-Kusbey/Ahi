using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services
{
    public interface ISellerService
    {
        Task CreateSeller(Address address);
        Task UpdateSeller(Address address);
        Task DeleteSeller(Guid uid);
        Task<Address> GetSeller(Guid uid);
    }
}
