using CampusAPI.Models.Moodle;

namespace CampusAPI.Models.HelpersModels
{
    public class UserWithRole
    {
        public MdlUser User { get; set; }
        public long RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
