using Esnaf.Application.Const.Enums;
using Esnaf.Application.ViewModels;

namespace Esnaf.Application.DTOs.Auth
{
    public class UserAccessedLoginDTO
    {
        public Guid Id { get; set; }
        public Token? Token { get; set; }
        public Roles Role { get; set; }
        public bool IsRegister { get; set; }
        public bool IsActive { get; set; }
    }
}
