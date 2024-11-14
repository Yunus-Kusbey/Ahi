using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Esnaf.API.Controllers
{
    [Authorize(Roles =("Seller,Customer"))]
    [Route("api/[Controller]")]
    public class AdressController:ControllerBase
    {
        IMediator _mediator;
        public AdressController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
