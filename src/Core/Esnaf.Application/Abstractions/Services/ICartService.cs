using Esnaf.Application.DTOs.Cart;
using Esnaf.Application.DTOs.Product;
using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services
{
    public interface ICartService
    {
        Task CreateCart(CartCreate model);
        Task AddProductCart(ProductCreate model);
        Task DeleteProductCart(Guid id);
        Task UpdateCart(CartUpdate model);
        Task DeleteCart(Guid uid);
        Task<Address> GetCart(Guid uid);
    }
}
