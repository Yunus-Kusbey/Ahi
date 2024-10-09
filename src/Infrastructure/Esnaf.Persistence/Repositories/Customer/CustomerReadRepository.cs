using Esnaf.Application.Entities;
using Esnaf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class CustomerReadRepository : ICustomerReadRepository
    {
        public IQueryable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetByIdAsync(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customer> GetWhere()
        {
            throw new NotImplementedException();
        }
    }
}
