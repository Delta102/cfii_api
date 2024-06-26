using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Recent activity block
/// </summary>
public partial class MdlBlockRecentActivity
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public long Cmid { get; set; }

    public long Timecreated { get; set; }

    public long Userid { get; set; }

    public bool Action { get; set; }

    public string? Modname { get; set; }
}
