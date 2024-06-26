using CampusAPI.Models.HelpersModels;
using CampusAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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

        [HttpGet("profile")]
        public IActionResult GetLoggedInUserProfile()
        {
            var loggedInUser = HttpContext.User;

            // Código de depuración: listar todos los claims
            var claims = loggedInUser.Claims;
            foreach (var claim in claims)
            {
                Console.WriteLine($"Claim Type: {claim.Type}, Claim Value: {claim.Value}");
            }

            var userIdClaim = loggedInUser.FindFirst(ClaimTypes.NameIdentifier);

            if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out var userId))
                return BadRequest("No se pudo obtener el ID del usuario");

            var user = _authService.GetUserWithRoleById(userId);

            if (user == null)
                return NotFound("Usuario no encontrado");

            return Ok(user);
        }
    }
}