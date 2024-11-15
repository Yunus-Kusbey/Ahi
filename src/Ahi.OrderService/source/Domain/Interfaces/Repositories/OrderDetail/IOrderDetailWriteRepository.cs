using Ahi.OrderService.source.Application.DTOs.Order;

namespace Ahi.OrderService.source.Domain.Interfaces.Repositories
{
    public interface IOrderDetailWriteRepository : IWriteRepository<OrderDetailCreateDTO, OrderDetailUpdateDTO, Guid>
    {
    }
}
