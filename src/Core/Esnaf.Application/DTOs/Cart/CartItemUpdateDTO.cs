using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Cart
{
    public class CartItemUpdateDTO
    {
        public Guid Id;
        public Guid CartId;
        public Guid ProductId;
        public Guid ProductPriceId;
        public int Quantity;
        public decimal Total;
        public short IsActive;
    }
}
