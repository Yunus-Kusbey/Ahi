using Ahi.ProductService.source.Application.DTOs.Category;
using MediatR;

namespace Ahi.ProductService.source.Application.Features.Commands.Category
{
    public class CategoryUpdateCommandRequest:CategoryUpdateDTO,IRequest<bool>
    {
    }
}
