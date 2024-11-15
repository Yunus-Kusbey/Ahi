using Ahi.ProductService.source.Application.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.ProductService.source.Domain.Interfaces.Repositories
{
    public interface IProductPriceWriteRepository : IWriteRepository<ProductPriceCreateDTO, ProductPriceUpdateDTO, Guid>
    {
    }
}
