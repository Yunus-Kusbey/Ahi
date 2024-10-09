using Esnaf.Domain.Entities;
using Esnaf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class ProductPricesReadRepository : IProductPriceReadRepository
    {
        public IQueryable<ProductPrice> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductPrice> GetByIdAsync(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProductPrice> GetWhere()
        {
            throw new NotImplementedException();
        }
    }
}
