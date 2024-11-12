using Esnaf.Application.Abstractions.Services;
using Esnaf.Application.Abstractions.Token;
using Esnaf.Application.DTOs;
using Esnaf.Application.DTOs.Auth;
using Esnaf.Application.Exceptions;
using Esnaf.Application.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.AppUser.LoginUser
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
                        return new LoginUserCommandResponse() { 
                        Token=user.Token,
                        UserId=user.Id,
                        Register=user.IsRegister
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