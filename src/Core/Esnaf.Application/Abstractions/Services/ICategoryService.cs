using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services
{
    public interface ICategoryService
    {
        Task CreateCategory(Address address);
        Task CreateSubCategory(Address address);
        Task UpdateCategory(Address address);
        Task DeleteCategory(Guid uid);
        Task<Address> GetAllCart(Guid uid);
    }
}
