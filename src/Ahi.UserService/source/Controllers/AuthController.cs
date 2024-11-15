using Ahi.UserService.source.Application.Features.Commands.LoginUser;
using Ahi.UserService.source.Application.Features.Commands.OTPSend;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ahi.UserService.source.Controllers
{

    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        IMediator _mediator;
        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> OTPSender([FromBody] OTPSendCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody] LoginUserCommandRequest number)
        {
            LoginUserCommandResponse response = await _mediator.Send(number);
            return Ok(response);
        }
    }
}
