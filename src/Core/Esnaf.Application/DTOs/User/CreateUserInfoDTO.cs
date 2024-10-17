using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.User
{
    public class CreateUserInfoDTO
    {
        public string Name { get; set;}
        public string Surname { get; set;}
        public string? Email { get; set;}
        public short Gender { get; set;}
    }
}
