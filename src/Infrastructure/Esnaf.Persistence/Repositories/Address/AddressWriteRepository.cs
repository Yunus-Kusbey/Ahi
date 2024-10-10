using Esnaf.Domain.Entities;
using Esnaf.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class AddressWriteRepository : IAddressWriteRepository
    {
        public Task<bool> AddAsync(Address entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Address id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Address id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Address entity)
        {
            throw new NotImplementedException();
        }
    }
}
