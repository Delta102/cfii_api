using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Aggregated grades for assessment are stored here. The aggreg
/// </summary>
public partial class MdlWorkshopAggregation
{
    public long Id { get; set; }

    public long Workshopid { get; set; }

    public long Userid { get; set; }

    public decimal? Gradinggrade { get; set; }

    public long? Timegraded { get; set; }
}
