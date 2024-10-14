using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Customer
{
    public class CustomerCreate
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public Guid AddressId { get; set; }
        public short Gender { get; set; }
        public DateTime BirthDay { get; set; }

    }
}
