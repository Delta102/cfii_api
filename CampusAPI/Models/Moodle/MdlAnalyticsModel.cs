using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Analytic models.
/// </summary>
public partial class MdlAnalyticsModel
{
    public long Id { get; set; }

    public bool Enabled { get; set; }

    public bool Trained { get; set; }

    public string? Name { get; set; }

    public string Target { get; set; } = null!;

    public string Indicators { get; set; } = null!;

    public string? Timesplitting { get; set; }

    public string? Predictionsprocessor { get; set; }

    public long Version { get; set; }

    public string? Contextids { get; set; }

    public long? Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }
}
