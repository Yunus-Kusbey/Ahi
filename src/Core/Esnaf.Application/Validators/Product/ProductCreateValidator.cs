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
            RuleFor(p=>p.Name).NotEmpty().MaximumLength(24).MinimumLength(2);
            RuleFor(p=>p.Description).NotEmpty();
            RuleFor(p=>p.Summary).NotEmpty();
            RuleFor(p=>p.CategoryId).NotEmpty();
        }
    }
}
