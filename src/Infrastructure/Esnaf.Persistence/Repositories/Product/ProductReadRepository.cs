using Esnaf.Domain.Entities;
using Esnaf.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class ProductReadRepository : IProductReadRepository
    {
        public IQueryable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetWhere()
        {
            throw new NotImplementedException();
        }
    }
}
