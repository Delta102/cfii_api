using CampusAPI.Models.HelpersModels;
using CampusAPI.Models.Moodle;

namespace CampusAPI.Services.UserServices
{
    public interface IUserServices
    {
        List<UserWithRole> GettAllUsersByRoleId(int roleId);
        MdlUser GetUserById(int userId);
    }
    public class UserServices : IUserServices
    {
        public readonly MoodleDBContext _dbContext;

        public UserServices(MoodleDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<UserWithRole> GettAllUsersByRoleId(int roleId)
        {
            return _dbContext.MdlUsers.
                Join(_dbContext.MdlRoleAssignments,
                    u => u.Id,
                    ra => ra.Userid,
                    (u, ra) => new { User = u, RoleAssignment = ra }).
                Join(_dbContext.MdlRoles,
                    ura => ura.RoleAssignment.Roleid,
                    r => r.Id,
                    (ura, r) => new { ura.User, Role = r }
                ).Where(ur => ur.Role.Id == roleId)
                .Select(ur => new UserWithRole
                {
                    UserId = ur.User.Id,
                    UserName = ur.User.Username,
                    RoleId = ur.Role.Id,
                    RoleName = ur.Role.Shortname,
                })
                .ToList();
        }

        public MdlUser GetUserById(int userId)
        {
            return _dbContext.MdlUsers.First( u => u.Id == userId);
        }
    }
}
