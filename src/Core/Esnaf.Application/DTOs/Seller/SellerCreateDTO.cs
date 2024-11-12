using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Seller
{
    public class SellerCreateDTO
    {
        public Guid Id { get; set; }
        public string? ShopName { get; set; }
        public string?  VKN { get; set; }
    }
}
