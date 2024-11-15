using Ahi.ProductService.source.Application.DTOs.Category;
using MediatR;

namespace Ahi.ProductService.source.Application.Features.Commands.Category
{
    public class CategoryCreateCommandRequest:CategoryCreateDTO,IRequest<bool>
    {
    }
}
