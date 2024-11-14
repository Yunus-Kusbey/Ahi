using Esnaf.Application.DTOs.Product;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Validators.Product
{
    public class ProductCategoryValidator:AbstractValidator<ProductCategoryDTO>
    {
        public ProductCategoryValidator() {
            RuleFor(p => p.ProductId).NotEmpty();
            RuleFor(p => p.CategoryId).NotEmpty();
        }
    }
}
