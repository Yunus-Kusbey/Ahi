
namespace Ahi.OrderService.source.Application.DTOs.Cart
{
    public class CartItemCreateDTO
    {
        public Guid CartId;
        public Guid ProductId;
        public Guid ProductPriceId;
        public int Quantity;
    }
}
