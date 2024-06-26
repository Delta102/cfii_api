using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Analytic models changes during evaluation.
/// </summary>
public partial class MdlAnalyticsModelsLog
{
    public long Id { get; set; }

    public long Modelid { get; set; }

    public long Version { get; set; }

    public string Evaluationmode { get; set; } = null!;

    public string Target { get; set; } = null!;

    public string Indicators { get; set; } = null!;

    public string? Timesplitting { get; set; }

    public decimal Score { get; set; }

    public string? Info { get; set; }

    public string Dir { get; set; } = null!;

    public long Timecreated { get; set; }

    public long Usermodified { get; set; }
}
