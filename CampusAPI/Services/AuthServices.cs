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
                new Claim(JwtRegisteredClaimNames.Sub, user.Username),
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

        public MdlUser GetLoggedInUser(ClaimsPrincipal user)
        {
            var userId = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (int.TryParse(userId, out int id))
            {
                return _dbContext.MdlUsers.SingleOrDefault(u => u.Id == id);
            }
            return null;
        }
    }
}
