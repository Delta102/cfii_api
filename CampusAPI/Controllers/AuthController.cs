using CampusAPI.Models.HelpersModels;
using CampusAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CampusAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthServices _authService;

        public AuthController(IAuthServices authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestAPI request)
        {
            var user = await _authService.Authenticate(request.Username, request.Password);

            if (user == null)
            {
                return Unauthorized("Invalid Username or Password");
            }

            return Ok(user);
        }
    }
}