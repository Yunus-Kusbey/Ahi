using Ahi.UserService.source.Application.Const.Enums;
using Ahi.UserService.source.Application.ViewModels;

namespace Ahi.UserService.source.Application.DTOs.Auth
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
