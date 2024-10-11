
namespace Esnaf.Domain.Entities
{
    public class Address
    {
        public Guid Id;
        public Guid CustomerId;
        public int ProvinceId;
        public int CountyId;
        public string? OpenAddress;
        public DateTime CreateDate;
        public bool IsActived;
    }
}
