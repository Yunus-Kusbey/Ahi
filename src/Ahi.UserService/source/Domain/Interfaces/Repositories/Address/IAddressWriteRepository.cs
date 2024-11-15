using Ahi.UserService.source.Application.DTOs.Address;

namespace Ahi.UserService.source.Domain.Interfaces.Repositories.Address
{
    public interface IAddressWriteRepository : IWriteRepository<AddressCreateDTO, AddressUpdateDTO, Guid>
    {
    }
}
