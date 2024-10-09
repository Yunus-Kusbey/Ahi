
namespace Esnaf.Domain.Entities
{
    public class CartItem
    {
        public int Id;
        public int CartId;
        public int ProductId;
        public int ProductPriceId;
        public int Quantity;
        public DateTime CreatedDate;
        public bool IsActive;
    }
}
