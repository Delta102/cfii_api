using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// To accumulate daily stats per course/user
/// </summary>
public partial class MdlStatsUserDaily
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public long Userid { get; set; }

    public long Roleid { get; set; }

    public long Timeend { get; set; }

    public long Statsreads { get; set; }

    public long Statswrites { get; set; }

    public string Stattype { get; set; } = null!;
}
