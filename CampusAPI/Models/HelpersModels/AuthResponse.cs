using CampusAPI.Models.Moodle;

namespace CampusAPI.Models.HelpersModels
{
    public class AuthResponse
    {
        public MdlUser User { get; set; }
        public string Token { get; set; }
    }
}
