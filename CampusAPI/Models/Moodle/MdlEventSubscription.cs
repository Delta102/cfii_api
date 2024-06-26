using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Tracks subscriptions to remote calendars.
/// </summary>
public partial class MdlEventSubscription
{
    public long Id { get; set; }

    public string Url { get; set; } = null!;

    public long Categoryid { get; set; }

    public long Courseid { get; set; }

    public long Groupid { get; set; }

    public long Userid { get; set; }

    public string Eventtype { get; set; } = null!;

    public long Pollinterval { get; set; }

    public long? Lastupdated { get; set; }

    public string Name { get; set; } = null!;
}
