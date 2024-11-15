using Ahi.UserService.source.Application.DTOs.Auth;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahi.UserService.source.Application.Features.Commands.OTPSend
{
    public class OTPSendCommandRequest : UserLoginDTO, IRequest<UserAccessedLoginDTO?>
    {
    }
}
