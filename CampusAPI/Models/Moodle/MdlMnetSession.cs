using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Store session data from users migrating to other sites
/// </summary>
public partial class MdlMnetSession
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public string Username { get; set; } = null!;

    public string Token { get; set; } = null!;

    public long Mnethostid { get; set; }

    public string Useragent { get; set; } = null!;

    public long ConfirmTimeout { get; set; }

    public string SessionId { get; set; } = null!;

    public long Expires { get; set; }
}
