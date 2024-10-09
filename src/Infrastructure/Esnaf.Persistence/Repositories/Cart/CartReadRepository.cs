using Esnaf.Domain.Entities;
using Esnaf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class CartReadRepository : ICartReadRepository
    {
        public IQueryable<Cart> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Cart> GetByIdAsync(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Cart> GetWhere()
        {
            throw new NotImplementedException();
        }
    }
}
