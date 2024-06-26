using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// modules available in the site
/// </summary>
public partial class MdlModule
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long Cron { get; set; }

    public long Lastcron { get; set; }

    public string Search { get; set; } = null!;

    public bool? Visible { get; set; }
}
