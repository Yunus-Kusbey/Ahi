using Esnaf.Domain.Entities;
using Esnaf.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esnaf.Application.DTOs.Product;

namespace Esnaf.Persistence.Repositories
{
    public class ProductWriteRepository : IProductWriteRepository
    {
        public Task<bool> AddAsync(ProductCreate entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductUpdate entity)
        {
            throw new NotImplementedException();
        }
    }
}
