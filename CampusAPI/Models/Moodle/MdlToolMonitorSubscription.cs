using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Table to store user subscriptions to various rules
/// </summary>
public partial class MdlToolMonitorSubscription
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public long Ruleid { get; set; }

    public long Cmid { get; set; }

    public long Userid { get; set; }

    public long Timecreated { get; set; }

    public long Lastnotificationsent { get; set; }

    public long Inactivedate { get; set; }
}
