﻿using Esnaf.Application.DTOs.Auth;
using MediatR;

namespace Esnaf.Application.Features.Commands.AppUser.LoginUser
{
    public class LoginUserCommandRequest : UserOTPLoginDTO,IRequest<LoginUserCommandResponse>
    {
    }
}