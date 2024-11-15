namespace Ahi.OrderService.source.Domain.Entities
{
    public class Order
    {
        public Guid Id;
        public Guid CustomerId;
        public Guid SellerId;
        public string? PaymentId;
        public Decimal Total;
        public DateTime CreatedDate;
        public bool IsActive;
        public string? Status;
        

    }
}
