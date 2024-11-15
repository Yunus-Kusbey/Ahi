using Ahi.SellerService.source.Application.DTOs.Seller;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.SellerService.source.Application.Validators.Seller
{
    public class SellerUpdateValidator:AbstractValidator<SellerUpdateDTO>
    {
        public SellerUpdateValidator() {
            RuleFor(p=>p.Id).NotEmpty();
            RuleFor(p => p.IsActive).NotEmpty();
            RuleFor(p => p.VKN).NotEmpty().MaximumLength(10);
            RuleFor(p => p.ShopName).NotEmpty().MaximumLength(25);
        }
    }
}
