using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Order
{
    public class OrderDetailUpdateDTO
    {
        public Guid Id;
        public Guid OrderId;
        public Guid ProductId;
        public Guid ProductPriceId;
        public int Quantity;
        public short IsActive;
    }
}
