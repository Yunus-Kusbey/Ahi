using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services
{
    public interface IProductService
    {
        Task CreateProduct(Address address);
        Task AddCategoryProduct(Address address);
        Task DeleteCategoryProduct(Address address);
        Task UpdateProduct(Address address);
        Task DeleteProduct(Guid uid);
        Task<Address> GetProduct(Guid uid);
        Task<List<Address>> GetAllProduct(Guid uid);
    }
}
