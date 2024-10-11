

namespace Esnaf.Domain.Entities
{
    public class Seller
    {
        public Guid Id;
        public string? Name;
        public string? VKN;
        public int AddressId;
        public DateTime CreatedDate;
        public bool IsActive;
    }
}
