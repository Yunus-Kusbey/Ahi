using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Cart
{
    public class CartCreateDTO
    {
        public Guid CustomerId { get; set; }
        public Guid SellerId { get; set; }
        public decimal Total { get; set; }
    }
}
