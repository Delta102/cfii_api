using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Changes done in server configuration through admin UI
/// </summary>
public partial class MdlConfigLog
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Timemodified { get; set; }

    public string? Plugin { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public string? Oldvalue { get; set; }
}
