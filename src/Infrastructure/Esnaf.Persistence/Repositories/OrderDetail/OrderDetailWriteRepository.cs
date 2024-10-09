using Esnaf.Domain.Entities;
using Esnaf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class OrderDetailWriteRepository : IOrderDetailWriteRepository
    {
        public Task<bool> AddAsync(OrderDetail entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(OrderDetail id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(OrderDetail id)
        {
            throw new NotImplementedException();
        }

        public bool Update(OrderDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
