using Esnaf.Application.DTOs.Product;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Validators.Product
{
    public class ProductCreateValidator : AbstractValidator<ProductCreateDTO>
    {
        public ProductCreateValidator()
        {
            RuleFor(p=>p.Name).NotEmpty().MaximumLength(25);
            RuleFor(p=>p.Description).NotEmpty().MaximumLength(300);
            RuleFor(p=>p.Summary).NotEmpty().MaximumLength(50);
            RuleFor(p=>p.CategoryId).NotEmpty();
        }
    }
}
