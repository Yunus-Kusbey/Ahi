using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Address
{
    public class AddressUpdate
    {
        public Guid Id;
        public string?  Name;
        public int ProvinceId;
        public int CountyId;
        public string? OpenAddress;
        public short IsActive = 1;
    }
}
