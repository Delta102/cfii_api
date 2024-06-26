using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// A table that keeps a log of events related to subscriptions
/// </summary>
public partial class MdlToolMonitorEvent
{
    public long Id { get; set; }

    public string Eventname { get; set; } = null!;

    public long Contextid { get; set; }

    public long Contextlevel { get; set; }

    public long Contextinstanceid { get; set; }

    public string Link { get; set; } = null!;

    public long Courseid { get; set; }

    public long Timecreated { get; set; }
}
