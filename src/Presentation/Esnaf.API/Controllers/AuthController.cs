using Esnaf.Application.Features.Commands.AppUser.LoginUser;
using Esnaf.Application.Features.Commands.AppUser.OTPSend;
using Esnaf.Application.Features.Commands.Customer;
using Esnaf.Application.Features.Commands.Seller;
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
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody] LoginUserCommandRequest number)
        {
            LoginUserCommandResponse response = await _mediator.Send(number);
            return Ok(response.Token);
        }

        [Authorize(Roles = "LoginSave")]
        [HttpPost("[action]")]
        public async Task<IActionResult> CustomerCreate([FromBody] CustomerCreateCommandRequest request)
        {
            Guid id = await _mediator.Send(request);
            return Ok(id);
        }

        [Authorize(Roles = "LoginSave")]
        [HttpPost("[action]")]
        public async Task<IActionResult> SellerCreate([FromBody] SellerCreateCommandRequest request)
        {
            Guid id = await _mediator.Send(request);
            return Ok(id);
        }
    }
}
