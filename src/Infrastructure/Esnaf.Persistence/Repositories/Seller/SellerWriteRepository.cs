using Esnaf.Domain.Entities;
using Esnaf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class SellerWriteRepository : ISellerWriteRepository
    {
        public Task<bool> AddAsync(Seller entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Seller id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Seller id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Seller entity)
        {
            throw new NotImplementedException();
        }
    }
}
