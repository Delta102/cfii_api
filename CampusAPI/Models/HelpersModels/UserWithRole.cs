namespace CampusAPI.Models.HelpersModels
{
    public class UserWithRole
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public long RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
