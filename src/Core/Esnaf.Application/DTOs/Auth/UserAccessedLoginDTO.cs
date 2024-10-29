using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Auth
{
    public class UserAccessedLoginDTO
    {
        public string Role { get; set;}
        public bool IsActive{ get; set;}
    }
}
