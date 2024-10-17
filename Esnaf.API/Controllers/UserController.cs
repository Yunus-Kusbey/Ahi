using Esnaf.Application.DTOs.User;
using Esnaf.Application.Features.Commands.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Esnaf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("create-user")]
        public async Task<IActionResult> CreateUser(UserCreateCommandRequest createUserCommandRequest)
        {
            CreateUserResponseDTO response = await _mediator.Send(createUserCommandRequest);
            return Ok(response);
        }
    }
}
