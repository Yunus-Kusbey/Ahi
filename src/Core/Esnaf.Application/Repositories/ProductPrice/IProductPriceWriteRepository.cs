using Esnaf.Application.DTOs.Product;
using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Repositories
{
    public interface IProductPriceWriteRepository:IWriteRepository<ProductPriceCreate,ProductPriceUpdate>
    {
    }
}
