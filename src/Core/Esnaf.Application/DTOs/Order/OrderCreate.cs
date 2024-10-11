using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Order
{
    public class OrderCreate
    {
        public Guid CustomerId { get; set; }
        public short PaymentId { get; set; }
        public decimal Total { get; set; }
        public Guid SellerId { get; set; }
        public short Status { get; set; }
    }
}
