using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stored indicator calculations
/// </summary>
public partial class MdlAnalyticsIndicatorCalc
{
    public long Id { get; set; }

    public long Starttime { get; set; }

    public long Endtime { get; set; }

    public long Contextid { get; set; }

    public string Sampleorigin { get; set; } = null!;

    public long Sampleid { get; set; }

    public string Indicator { get; set; } = null!;

    public decimal? Value { get; set; }

    public long Timecreated { get; set; }
}
