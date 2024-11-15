using Ahi.ProductService.source.Application.DTOs.Product;
using FluentValidation;

namespace Ahi.ProductService.source.Application.Validators.Product
{
    public class ProductCategoryValidator:AbstractValidator<ProductCategoryDTO>
    {
        public ProductCategoryValidator() {
            RuleFor(p => p.ProductId).NotEmpty();
            RuleFor(p => p.CategoryId).NotEmpty();
        }
    }
}
