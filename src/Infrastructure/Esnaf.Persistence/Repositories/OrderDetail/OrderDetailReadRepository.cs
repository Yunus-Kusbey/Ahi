using Esnaf.Domain.Entities;
using Esnaf.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class OrderDetailReadRepository : IOrderDetailReadRepository
    {
        public IQueryable<OrderDetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetail> GetByIdAsync(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<OrderDetail> GetWhere()
        {
            throw new NotImplementedException();
        }
    }
}
