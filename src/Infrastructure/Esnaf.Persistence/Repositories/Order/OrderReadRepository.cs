using Esnaf.Domain.Entities;
using Esnaf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class OrderReadRepository : IOrderReadRepository
    {
        public IQueryable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetByIdAsync(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> GetWhere()
        {
            throw new NotImplementedException();
        }
    }
}
