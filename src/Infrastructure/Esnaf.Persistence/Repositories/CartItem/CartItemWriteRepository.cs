using Esnaf.Domain.Entities;
using Esnaf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
{
    public class CartItemWriteRepository : ICartItemWriteRepository
    {
        public Task<bool> AddAsync(CartItem entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(CartItem id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(CartItem id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CartItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
