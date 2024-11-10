using Esnaf.Application.DTOs.Auth;
using Esnaf.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Features.Commands.AppUser.OTPSend
{
    public class OTPSendCommandRequest:UserLoginDTO,IRequest<Token?>
    {
    }
}
