using Esnaf.Domain.Entities;
using Esnaf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class ProductPricesWriteRepository : IProductPriceWriteRepository
    {
        public Task<bool> AddAsync(ProductPrice entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ProductPrice id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(ProductPrice id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductPrice entity)
        {
            throw new NotImplementedException();
        }
    }
}
