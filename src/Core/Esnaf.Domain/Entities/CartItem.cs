
namespace Esnaf.Domain.Entities
{
    public class CartItem
    {
        public int Id;
        public Guid CartId;
        public Guid ProductId;
        public Guid ProductPriceId;
        public int Quantity;
        public DateTime CreatedDate;
        public bool IsActive;
    }
}
