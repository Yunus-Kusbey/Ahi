using Esnaf.Domain.Entities;
using Esnaf.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class CartWriteRepository : ICartWriteRepository
    {
        public Task<bool> AddAsync(Cart entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Cart id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Cart id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cart entity)
        {
            throw new NotImplementedException();
        }
    }
}
