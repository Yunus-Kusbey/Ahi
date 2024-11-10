using Esnaf.Application.Features.Commands.AppUser.LoginUser;
using Esnaf.Application.Features.Commands.AppUser.OTPSend;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Esnaf.API.Controllers
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
            if (request == null)
            {
                return BadRequest();
            }
            else
            {
                var response = await _mediator.Send(request);
                return Ok(response);
            }
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody] LoginUserCommandRequest number)
        {
            LoginUserCommandResponse response = await _mediator.Send(number);
            return Ok(response.Token);
        }
        [Authorize(Roles = "admin")]
        [HttpGet("admin")]
        public IActionResult AdminOnlyEndpoint()
        {
            return Ok("Bu sadece adminler için.");
        }

        [Authorize(Roles = "user")]
        [HttpGet("user")]
        public IActionResult UserOnlyEndpoint()
        {
            return Ok("Bu sadece kullanıcılar için.");
        }
    }
}
