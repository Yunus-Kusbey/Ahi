using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Order
{
    public class OrderDetailCreate
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public Guid ProductPrice { get; set; }
        public int Quantity { get; set; }
    }
}
