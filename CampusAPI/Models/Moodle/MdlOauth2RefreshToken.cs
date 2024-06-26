using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

public partial class MdlOauth2RefreshToken
{
    public long Id { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Userid { get; set; }

    public long Issuerid { get; set; }

    public string Token { get; set; } = null!;

    public string Scopehash { get; set; } = null!;
}
