
namespace Ahi.OrderService.source.Application.DTOs.Order
{
    public class OrderDetailCreateDTO
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public Guid ProductPriceId { get; set; }
        public int Quantity { get; set; }
    }
}
