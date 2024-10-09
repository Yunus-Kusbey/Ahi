using Esnaf.Domain.Entities;
using Esnaf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class AddressReadRepository : IAddressReadRepository
    {
        public IQueryable<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetByIdAsync(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Address> GetWhere()
        {
            throw new NotImplementedException();
        }
    }
}
