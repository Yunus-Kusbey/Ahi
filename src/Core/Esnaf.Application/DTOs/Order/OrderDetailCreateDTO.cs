using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Order
{
    public class OrderDetailCreateDTO
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public Guid ProductPriceId { get; set; }
        public int Quantity { get; set; }
    }
}
