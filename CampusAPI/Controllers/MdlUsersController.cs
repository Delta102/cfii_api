using Microsoft.AspNetCore.Mvc;
using CampusAPI.Models.HelpersModels;
using CampusAPI.Services.UserServices;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace CampusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MdlUsersController : Controller
    {
        private readonly IUserServices _userServices;

        public MdlUsersController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        [Authorize]
        [HttpGet("all/{roleId}")]
        public IEnumerable<UserWithRole> GetAllWorkers(int roleId)
        {
            return _userServices.GettAllUsersByRoleId(roleId);
        }
        [Authorize]
        [HttpGet("profile")]
        public IActionResult GetLoggedInUserProfile()
        {
            var loggedInUser = HttpContext.User;
            var userId = loggedInUser.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
                return BadRequest("No se pudo obtener el ID del usuario");

            var user = _userServices.GetUserById(int.Parse(userId));

            if (user == null)
                return NotFound("Usuario no encontrado");

            return Ok(user);
        }
    }
}
