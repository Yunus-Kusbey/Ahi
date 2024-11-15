using Ahi.UserService.source.Domain.Interfaces.Services;
using MediatR;

namespace Ahi.UserService.source.Application.Features.Commands.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse?>
    {
        readonly private IAuthService _authService;
        public LoginUserCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<LoginUserCommandResponse?> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            if (request.Phone != null && request.OTPCode != null)
            {
                var user = await _authService.PhoneLoginAsync(request.Phone);
                if (user != null)
                {
                    if (await _authService.VerifyOTPAsync(request))
                    {
                        return new LoginUserCommandResponse()
                        {
                            Token = user.Token,
                            UserId = user.Id,
                            Register = user.IsRegister
                        };
                    };
                    //OTP doğrulanmadı
                    return null;
                }
                return null;
            }
            else { return null; }
        }
    }
}