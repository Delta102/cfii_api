using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlBadgeBackpackOauth2
{
    public long Id { get; set; }

    public long Usermodified { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Userid { get; set; }

    public long Issuerid { get; set; }

    public long Externalbackpackid { get; set; }

    public string Token { get; set; } = null!;

    public string Refreshtoken { get; set; } = null!;

    public long? Expires { get; set; }

    public string? Scope { get; set; }
}
