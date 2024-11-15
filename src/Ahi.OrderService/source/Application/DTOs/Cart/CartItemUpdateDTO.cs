
namespace Ahi.OrderService.source.Application.DTOs.Cart
{
    public class CartItemUpdateDTO
    {
        public Guid Id;
        public Guid CartId;
        public Guid ProductId;
        public Guid ProductPriceId;
        public int Quantity;
        public decimal Total;
        public short IsActive;
    }
}
