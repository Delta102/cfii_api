using CampusAPI.Models.Moodle;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using CampusAPI.Models.HelpersModels;

namespace CampusAPI.Services
{
    public interface IAuthServices
    {
        public Task<AuthResponse> Authenticate(string username, string password);
        UserWithRole GetUserWithRoleById(int userId);
    }
    public class AuthServices : IAuthServices
    {
        private readonly MoodleDBContext _dbContext;
        private readonly IConfiguration _configuration;

        public AuthServices(MoodleDBContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        public async Task<AuthResponse> Authenticate(string username, string password)
        {
            var user = await _dbContext.MdlUsers.SingleOrDefaultAsync(x => x.Username == username);

            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
                return null;

                
            var token = GenerateJwtToken(user);
            return new AuthResponse
            {
                User = user,
                Token = token,
            };
        }

        private string GenerateJwtToken(MdlUser user)
        {
            var claims = new[]
                        {
                new Claim("Username", user.Username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(10),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public UserWithRole GetUserWithRoleById(int userId)
        {
            var userWithRole = _dbContext.MdlUsers
                .Where(u => u.Id == userId)
                .Join(_dbContext.MdlRoleAssignments,
                    u => u.Id,
                    ra => ra.Userid,
                    (u, ra) => new { User = u, RoleAssignment = ra })
                .Join(_dbContext.MdlRoles,
                    ura => ura.RoleAssignment.Roleid,
                    r => r.Id,
                    (ura, r) => new { ura.User, Role = r })
                .Select(ur => new UserWithRole
                {
                    User = ur.User,
                    RoleId = ur.Role.Id,
                    RoleName = ur.Role.Shortname
                })
                .FirstOrDefault();

            if (userWithRole != null)
            {
                // Obtener el contexto ID del usuario
                var contextId = _dbContext.MdlContexts
                    .Where(c => c.Contextlevel == 30 && c.Instanceid == userWithRole.User.Id)
                    .Select(c => c.Id)
                    .FirstOrDefault();

                if (contextId != null)
                {
                    // Construir la URL de la imagen del usuario
                    string pictureUrl = $"https://campusindustrial.unmsm.edu.pe/moodle/pluginfile.php/{contextId}/user/icon/adaptable/f1?rev={userWithRole.User.Picture}";

                    // Aquí puedes devolver la URL de la imagen junto con el usuario y el rol
                    userWithRole.PictureUrl = pictureUrl;
                }
            }

            return userWithRole;
        }
    }
}
