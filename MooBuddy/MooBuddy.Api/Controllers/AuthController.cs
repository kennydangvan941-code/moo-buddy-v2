using Microsoft.AspNetCore.Mvc;
using MooBuddy.Application.Features.Auth.RegisterWithEmail;

namespace MooBuddy.Api.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : Controller
    {
        private readonly RegisterWithEmailExecution _execution;

        public AuthController(RegisterWithEmailExecution execution)
        {
            _execution = execution;
        }

        [HttpPost("register-email")]
        public async Task<IActionResult> RegisterEmail([FromBody] RegisterWithEmailRequest req)
        {
            var result = await _execution.ExecuteAsync(req.Email, req.Password, req.FullName);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}