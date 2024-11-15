namespace Ahi.OrderService.source.Application.DTOs.Cart
{
    public class CartCreateDTO
    {
        public Guid CustomerId { get; set; }
        public Guid SellerId { get; set; }
        public decimal Total { get; set; }
    }
}
