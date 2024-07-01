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
        https://campusindustrial.unmsm.edu.pe/moodle/pluginfile.php/103896/user/icon/adaptable/f1?rev=10124763


            var loggedInUser = HttpContext.User;

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