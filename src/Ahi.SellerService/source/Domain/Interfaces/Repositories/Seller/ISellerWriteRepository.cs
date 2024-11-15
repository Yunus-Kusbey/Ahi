using Ahi.SellerService.source.Application.DTOs.Seller;

namespace Ahi.SellerService.source.Domain.Interfaces.Repositories
{
    public interface ISellerWriteRepository : IWriteRepository<SellerCreateDTO, SellerUpdateDTO, Guid>
    {
    }
}
