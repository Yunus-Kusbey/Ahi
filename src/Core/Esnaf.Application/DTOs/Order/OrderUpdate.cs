using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Order
{
    public class OrderUpdate
    {
        public Guid Id;
        public Guid CustomerId;
        public short PaymentId;
        public Guid SellerId;
        public short Status;
        public decimal Total;
        public short IsActive;
    }
}
