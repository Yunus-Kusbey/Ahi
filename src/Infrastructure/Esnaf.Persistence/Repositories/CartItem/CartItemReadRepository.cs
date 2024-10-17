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
    public class CartItemReadRepository : ICartItemReadRepository
    {
        public IQueryable<CartItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CartItem> GetByIdAsync(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<CartItem> GetWhere()
        {
            throw new NotImplementedException();
        }
    }
}
