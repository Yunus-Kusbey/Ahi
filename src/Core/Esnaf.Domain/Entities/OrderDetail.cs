

namespace Esnaf.Domain.Entities
{
    public class OrderDetail
    {
        public Guid Id;
        public Guid OrderId;
        public Guid ProductId;
        public Guid ProductPrice;
        public int Quantity;
        public DateTime CreatedDate;
        public bool IsActive;
    }
}
