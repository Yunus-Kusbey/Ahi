using Ahi.SellerService.source.Application.DTOs.Seller;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.SellerService.source.Application.Validators.Seller
{
    public class SellerCreateValidator : AbstractValidator<SellerCreateDTO>
    {
        public SellerCreateValidator()
        {
            RuleFor(p => p.UserId).NotEmpty();
            RuleFor(p=> p.VKN).NotEmpty().MaximumLength(10);
            RuleFor(p=>p.ShopName).NotEmpty().MaximumLength(25);
        }
    }
}
