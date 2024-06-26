using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// List of analysables used by each model
/// </summary>
public partial class MdlAnalyticsUsedAnalysable
{
    public long Id { get; set; }

    public long Modelid { get; set; }

    public string Action { get; set; } = null!;

    public long Analysableid { get; set; }

    public long Firstanalysis { get; set; }

    public long Timeanalysed { get; set; }
}
