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
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
    {
        readonly IAuthService _authService;
        public LoginUserCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            //Otp kodu ile telefon numarası buraya gelecek ve jwt ye kayıtlı mı deil mi diye kod eklenecek kayıtlı deil ise kayıt ekleme mediatr a gidecek
            //ordanda kayıt yapılacak
            if (request != null)
            {
                var token = await _authService.PhoneLoginAsync(request.Phone);
                return new LoginUserCommandResponse()
                {
                    Token = token,
                };
            }
            else { throw new NotFoundUserException(); }
        }
    }
}