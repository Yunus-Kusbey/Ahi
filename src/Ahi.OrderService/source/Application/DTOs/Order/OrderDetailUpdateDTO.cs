
namespace Ahi.OrderService.source.Application.DTOs.Order
{
    public class OrderDetailUpdateDTO
    {
        public Guid Id;
        public Guid OrderId;
        public Guid ProductId;
        public Guid ProductPriceId;
        public int Quantity;
        public short IsActive;
    }
}
