using Esnaf.Domain.Entities;
using Esnaf.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class ProductWriteRepository : IProductWriteRepository
    {
        public Task<bool> AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Product id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Product id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
