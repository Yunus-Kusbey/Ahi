using Ahi.ProductService.source.Application.DTOs.Product;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.ProductService.source.Application.Validators.Product
{
    public class ProductPriceUpdateValidator : AbstractValidator<ProductPriceUpdateDTO>
    {
        public ProductPriceUpdateValidator()
        {
            RuleFor(p => p.Name).NotEmpty().MaximumLength(25);
            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.IsActive).NotEmpty();
        }
    }
}
