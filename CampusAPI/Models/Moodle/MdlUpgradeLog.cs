using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Upgrade logging
/// </summary>
public partial class MdlUpgradeLog
{
    public long Id { get; set; }

    public long Type { get; set; }

    public string? Plugin { get; set; }

    public string? Version { get; set; }

    public string? Targetversion { get; set; }

    public string Info { get; set; } = null!;

    public string? Details { get; set; }

    public string? Backtrace { get; set; }

    public long Userid { get; set; }

    public long Timemodified { get; set; }
}
