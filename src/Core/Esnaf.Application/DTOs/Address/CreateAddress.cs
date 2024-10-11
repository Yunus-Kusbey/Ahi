using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Address
{
    public class CreateAddress
    {
        public Guid CustomerId { get; set; }
        public string? Name { get; set; }
        public int ProvinceId { get; set; }
        public int CountyId { get; set; }
        public string? OpenAddress { get; set; }

    }
}
