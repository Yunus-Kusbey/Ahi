using Esnaf.Application.DTOs.Product;
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
        Task CreateProduct(ProductCreate model);
        Task AddCategoryProduct(ProductCategory model);
        Task DeleteCategoryProduct(ProductCategory model);
        Task ProductPriceAdd(ProductPriceCreate model);        
        Task ProductPriceUpdate(ProductPriceUpdate model);
        Task UpdateProduct(ProductUpdate address);
        Task ProductPriceRemove(Guid id);
        Task DeleteProduct(Guid uid);
        Task<Address> GetProduct(Guid uid);
        Task<List<Address>> GetAllProduct(Guid uid);
    }
}
