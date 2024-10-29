using Esnaf.Application.DTOs.Auth;
using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Repositories
{
    public interface IUserReadRepository:IReadRepository<User>
    {
        public Task<UserAccessedLoginDTO> Control(string PhoneNumber);
    }
}
