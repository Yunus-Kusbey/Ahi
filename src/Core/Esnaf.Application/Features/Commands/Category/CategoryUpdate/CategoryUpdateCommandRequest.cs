using Esnaf.Application.DTOs.Category;
using MediatR;

namespace Esnaf.Application.Features.Commands.Category
{
    public class CategoryUpdateCommandRequest:CategoryUpdateDTO,IRequest<bool>
    {
    }
}
