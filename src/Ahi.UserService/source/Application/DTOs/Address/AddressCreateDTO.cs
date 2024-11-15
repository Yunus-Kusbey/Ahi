using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.UserService.source.Application.DTOs.Address
{
    public class AddressCreateDTO
    {
        public Guid CustomerId { get; set; }
        public string? Name { get; set; }
        public short ProvinceId { get; set; }
        public Int16 CountyId { get; set; }
        public string? OpenAddress { get; set; }

    }
}
