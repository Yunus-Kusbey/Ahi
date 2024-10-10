using Esnaf.Domain.Entities;
using Esnaf.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class SellerReadRepository : ISellerReadRepository
    {
        public IQueryable<Seller> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Seller> GetByIdAsync(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Seller> GetWhere()
        {
            throw new NotImplementedException();
        }
    }
}
