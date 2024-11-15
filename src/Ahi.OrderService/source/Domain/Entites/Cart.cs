namespace Ahi.OrderService.source.Domain.Entities
{
    public class Cart
    {
        public Guid Id;
        public Guid CustomerId;
        public Guid SellerId;
        public Decimal Total;
        public DateTime CreateDate;
        public bool IsActived;

        public ICollection<CartItem>? CartItems;

    }
}
