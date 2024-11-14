using Esnaf.Application.Features.Commands.Customer;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Esnaf.API.Controllers
{
    [Authorize(Roles ="Customer")]
    [Route("api/[controller]")]
    public class CustomerController:ControllerBase
    {
        IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update([FromBody] CustomerUpdateCommandRequest request)
        {
            bool id = await _mediator.Send(request);
            return Ok(id);
        }
    }
}
