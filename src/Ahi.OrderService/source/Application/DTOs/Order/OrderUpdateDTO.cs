
namespace Ahi.OrderService.source.Application.DTOs.Order
{
    public class OrderUpdateDTO
    {
        public Guid Id;
        public Guid CustomerId;
        public short PaymentId;
        public Guid SellerId;
        public short Status;
        public decimal Total;
        public short IsActive;
    }
}
