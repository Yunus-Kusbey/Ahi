using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.ProductService.source.Application.DTOs.Product
{
    public class ProductPriceUpdateDTO
    {
        public Guid Id;
        public decimal Price;
        public string? Name;
        public short IsActive;
    }
}
