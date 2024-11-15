using Ahi.OrderService.source.Application.DTOs.Cart;

namespace Ahi.OrderService.source.Domain.Interfaces.Repositories
{
    public interface ICartWriteRepository : IWriteRepository<CartCreateDTO, CartUpdateDTO, Guid>
    {
    }
}
