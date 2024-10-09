
namespace Esnaf.Domain.Entities
{
    public class Order
    {
        public Guid Uid;
        public int CustomerId;
        public string? PaymentId;
        public Decimal Total;
        public DateTime CreatedDate;
        public bool IsActive;
        public string? Status;
        public int SellerId;

    }
}
