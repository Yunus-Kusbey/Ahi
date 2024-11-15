using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.UserService.source.Application.DTOs.Auth
{
    public class UserOTPLoginDTO
    {
        public string? Phone { get; set; }
        public string? OTPCode { get; set; }
    }
}
