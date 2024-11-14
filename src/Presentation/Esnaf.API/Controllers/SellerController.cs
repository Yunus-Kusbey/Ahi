using Esnaf.Application.Features.Commands.Seller;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Esnaf.API.Controllers
{
    [Authorize(Roles ="Seller")]
    [Route("api/[controller]")]
    public class SellerController:ControllerBase
    {
        IMediator _mediator;
        public SellerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update([FromBody] SellerUpdateCommandRequest request)
        {
            bool id = await _mediator.Send(request);
            return Ok(id);
        }
    }
}
