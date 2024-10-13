using Esnaf.Domain.Entities;
using Esnaf.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esnaf.Application.DTOs.Customer;

namespace Esnaf.Persistence
{
    public class CustomerWriteRepository : ICustomerWriteRepository
    {
        public Task<bool> AddAsync(CustomerCreate entity)
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

        public bool Update(CustomerUpdate entity)
        {
            throw new NotImplementedException();
        }
    }
}
