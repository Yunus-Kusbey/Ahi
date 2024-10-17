using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Seller
{
    public class SellerCreateDTO
    {
        public Guid UserId { get; set; }
        public string? ShopName;
        public string?  VKN;
        public Guid AddressId;
    }
}
