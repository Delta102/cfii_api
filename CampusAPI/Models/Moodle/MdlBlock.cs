using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// contains all installed blocks
/// </summary>
public partial class MdlBlock
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long Cron { get; set; }

    public long Lastcron { get; set; }

    public bool? Visible { get; set; }
}
