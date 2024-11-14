using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Seller
{
    public class SellerUpdateDTO
    {
        public Guid Id;
        public string? ShopName;
        public string? VKN;
        public short IsActive;
    }
}
