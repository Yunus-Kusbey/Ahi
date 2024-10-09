

namespace Esnaf.Domain.Entities
{
    public class Cart
    {
        public Guid Uid;
        public int CustomerId;
        public int SellerId;
        public Decimal Total;
        public DateTime CreateDate;
        public bool IsActived;

        public ICollection<CartItem>? CartItems;

    }
}
