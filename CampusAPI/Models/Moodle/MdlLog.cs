using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Every action is logged as far as possible
/// </summary>
public partial class MdlLog
{
    public long Id { get; set; }

    public long Time { get; set; }

    public long Userid { get; set; }

    public string Ip { get; set; } = null!;

    public long Course { get; set; }

    public string Module { get; set; } = null!;

    public long Cmid { get; set; }

    public string Action { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Info { get; set; } = null!;
}
