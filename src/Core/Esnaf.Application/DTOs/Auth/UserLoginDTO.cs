using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.DTOs.Auth
{
    public class UserLoginDTO
    {
        public int Phone { get; set;}
        public string? Token { get; set;}
        public DateTime? Expration { get; set;}
    }
}
