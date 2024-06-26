using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Database based session storage - now recommended
/// </summary>
public partial class MdlSession
{
    public long Id { get; set; }

    public long State { get; set; }

    public string Sid { get; set; } = null!;

    public long Userid { get; set; }

    public string? Sessdata { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public string? Firstip { get; set; }

    public string? Lastip { get; set; }
}
