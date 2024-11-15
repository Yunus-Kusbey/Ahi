
namespace Ahi.OrderService.source.Application.DTOs.Order
{
    public class OrderCreateDTO
    {
        public Guid CustomerId { get; set; }
        public Guid AdressId { get; set; }
        public short PaymentId { get; set; }
        public decimal Total { get; set; }
        public Guid SellerId { get; set; }
        public short Status { get; set; }
    }
}
