using Esnaf.Application.DTOs.Category;
using MediatR;

namespace Esnaf.Application.Features.Commands.Category
{
    public class CategoryCreateCommandRequest:CategoryCreateDTO,IRequest<bool>
    {
    }
}
