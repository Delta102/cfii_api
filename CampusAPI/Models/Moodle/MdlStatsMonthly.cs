using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// To accumulate monthly stats
/// </summary>
public partial class MdlStatsMonthly
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public long Timeend { get; set; }

    public long Roleid { get; set; }

    public string Stattype { get; set; } = null!;

    public long Stat1 { get; set; }

    public long Stat2 { get; set; }
}
