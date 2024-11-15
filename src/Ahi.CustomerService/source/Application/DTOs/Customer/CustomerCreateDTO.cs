
namespace Ahi.CustomerService.source.Application.DTOs.Customer
{
    public class CustomerCreateDTO
    {
        public Guid Id{ get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public short Gender { get; set; }
        public DateTime BirthDay { get; set; }

    }
}
