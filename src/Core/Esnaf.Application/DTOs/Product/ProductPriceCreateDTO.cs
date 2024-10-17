using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Product
{
    public class ProductPriceCreateDTO
    {
        public Guid ProductId;
        public decimal Price;
        public string? Name;

    }
}
