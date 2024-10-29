using Esnaf.Application.DTOs;
using Esnaf.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Repositories
{
    public interface IUserWriteRepository:IWriteRepository<CreateUserDTO,UpdateUserDTO,Guid>
    {
        Task<bool> UserInfoAddAsync(CreateUserInfoDTO create);
    }
}
