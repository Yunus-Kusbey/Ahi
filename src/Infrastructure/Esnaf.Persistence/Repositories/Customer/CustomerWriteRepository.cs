using Esnaf.Application.Entities;
using Esnaf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence
{
    public class CustomerWriteRepository : ICustomerWriteRepository
    {
        public Task<bool> AddAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Customer id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Customer id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
