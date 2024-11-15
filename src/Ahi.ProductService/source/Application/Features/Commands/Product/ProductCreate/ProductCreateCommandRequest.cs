using Ahi.ProductService.source.Application.DTOs.Product;
using MediatR;
namespace Ahi.ProductService.source.Application.Features.Commands.Product
{
    public class ProductCreateCommandRequest : ProductCreateDTO,IRequest<string>
    {


    }
}
