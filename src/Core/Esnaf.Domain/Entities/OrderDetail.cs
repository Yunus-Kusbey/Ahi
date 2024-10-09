

namespace Esnaf.Domain.Entities
{
    public class OrderDetail
    {
        public Guid Uid;
        public int OrderId;
        public int ProductId;
        public int ProductPrice;
        public int Quantity;
        public DateTime CreatedDate;
        public bool IsActive;
    }
}
