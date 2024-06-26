using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Samples used for training
/// </summary>
public partial class MdlAnalyticsTrainSample
{
    public long Id { get; set; }

    public long Modelid { get; set; }

    public long Analysableid { get; set; }

    public string Timesplitting { get; set; } = null!;

    public string Sampleids { get; set; } = null!;

    public long Timecreated { get; set; }
}
