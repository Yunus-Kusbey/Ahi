using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.ProductService.source.Application.DTOs.Product
{
    public class ProductUpdateDTO
    {
        public Guid Id;
        public string? Name;
        public string? Description;
        public string? Summary;
        public int CategoryId;
        public short IsActive;
    }
}
