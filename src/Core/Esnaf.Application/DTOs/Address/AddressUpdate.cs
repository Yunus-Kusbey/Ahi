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
        public short ProvinceId;
        public Int16 CountyId;
        public string? OpenAddress;
        public short IsActive = 1;
    }
}
