using Ahi.OrderService.source.Application.DTOs.Cart;

namespace Ahi.OrderService.source.Domain.Interfaces.Repositories
{
    public interface ICartItemWriteRepository : IWriteRepository<CartItemCreateDTO, CartItemUpdateDTO, int>
    {
    }
}
