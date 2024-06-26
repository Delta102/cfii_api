using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Predictions
/// </summary>
public partial class MdlAnalyticsPrediction
{
    public long Id { get; set; }

    public long Modelid { get; set; }

    public long Contextid { get; set; }

    public long Sampleid { get; set; }

    public int Rangeindex { get; set; }

    public decimal Prediction { get; set; }

    public decimal Predictionscore { get; set; }

    public string Calculations { get; set; } = null!;

    public long Timecreated { get; set; }

    public long? Timestart { get; set; }

    public long? Timeend { get; set; }
}
