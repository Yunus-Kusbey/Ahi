using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Address
{
    public class CreateAddress
    {
        public Guid CustomerId;
        public int ProvinceId;
        public int CountyId;
        public string? OpenAddress;

    }
}
