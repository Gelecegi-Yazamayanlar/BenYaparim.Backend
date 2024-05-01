using Application.Features.Admin;
using Application.Features.Admin.Commands.Role;
using Application.Features.Admin.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("role/[action]")]
        public async Task<IActionResult> Add([FromBody] AddOperationClaimCommand command)
        {
            await _mediator.Send(command);
            return Created();
        }

        [HttpGet("role/[action]")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllOperationClaimQuery command)
        {
            GetAllOperationClaimQueryResponse resp = await _mediator.Send(command);
            return Ok(resp);
        }
    }
}
