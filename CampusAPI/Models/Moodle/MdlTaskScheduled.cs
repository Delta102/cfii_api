using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// List of scheduled tasks to be run by cron.
/// </summary>
public partial class MdlTaskScheduled
{
    public long Id { get; set; }

    public string Component { get; set; } = null!;

    public string Classname { get; set; } = null!;

    public long? Lastruntime { get; set; }

    public long? Nextruntime { get; set; }

    public sbyte Blocking { get; set; }

    public string Minute { get; set; } = null!;

    public string Hour { get; set; } = null!;

    public string Day { get; set; } = null!;

    public string Month { get; set; } = null!;

    public string Dayofweek { get; set; } = null!;

    public long? Faildelay { get; set; }

    public sbyte Customised { get; set; }

    public bool Disabled { get; set; }

    public long? Timestarted { get; set; }

    public string? Hostname { get; set; }

    public long? Pid { get; set; }
}
