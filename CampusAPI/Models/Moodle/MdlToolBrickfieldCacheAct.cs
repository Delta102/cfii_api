using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Contains accessibility summary information per activity.
/// </summary>
public partial class MdlToolBrickfieldCacheAct
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public bool? Status { get; set; }

    public string? Component { get; set; }

    public long? Totalactivities { get; set; }

    public long? Failedactivities { get; set; }

    public long? Passedactivities { get; set; }

    public long? Errorcount { get; set; }
}
