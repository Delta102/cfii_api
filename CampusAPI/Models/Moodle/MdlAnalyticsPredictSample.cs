using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Samples already used for predictions.
/// </summary>
public partial class MdlAnalyticsPredictSample
{
    public long Id { get; set; }

    public long Modelid { get; set; }

    public long Analysableid { get; set; }

    public string Timesplitting { get; set; } = null!;

    public long Rangeindex { get; set; }

    public string Sampleids { get; set; } = null!;

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
