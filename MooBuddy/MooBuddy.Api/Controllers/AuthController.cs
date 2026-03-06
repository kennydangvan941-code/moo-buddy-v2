using Microsoft.AspNetCore.Mvc;
using MooBuddy.Application.Features.Auth.RegisterWithEmail;

namespace MooBuddy.Api.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : Controller
    {
        [HttpPost("register-email")]
        public async Task<IActionResult> RegisterEmail(
        [FromBody] RegisterWithEmailRequest req,
        [FromServices] RegisterWithEmailExecution execution)
        {
            var result = await execution.ExecuteAsync(req.Email, req.Password, req.FullName);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
