using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Product
{
    public class ProductPriceUpdate
    {
        public Guid Id;
        public Guid ProductId;
        public decimal Price;
        public string? Name;
        public short IsActive;
    }
}
