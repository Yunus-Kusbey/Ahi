using Esnaf.Domain.Entities;
using Esnaf.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esnaf.Application.DTOs.Cart;

namespace Esnaf.Persistence.Repositories
{
    public class CartWriteRepository : ICartWriteRepository
    {
        public Task<bool> AddAsync(CartCreate entity)
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

        public bool Update(CartUpdate entity)
        {
            throw new NotImplementedException();
        }
    }
}
