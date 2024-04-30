using Application.Features.Auth.Commands.Login;
using Application.Features.Auth.Commands.Register;
using Core.Utilities.JWT;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginCommand loginCommand)
        {
            AccessToken response = await _mediator.Send(loginCommand);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterCommand registerCommand)
        {
            await _mediator.Send(registerCommand);
            return Ok();
        }
    }
}
