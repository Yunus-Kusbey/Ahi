using Ahi.ProductService.source.Application.DTOs.Product;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.ProductService.source.Application.Validators.Product
{
    public class ProductPriceCreateValidator : AbstractValidator<ProductPriceCreateDTO>
    {
        public ProductPriceCreateValidator()
        {
            RuleFor(p => p.Name).NotEmpty().MaximumLength(25);
            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.ProductId).NotEmpty();
        }
    }
}
