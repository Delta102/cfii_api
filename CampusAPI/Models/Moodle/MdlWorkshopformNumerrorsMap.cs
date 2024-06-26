using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This maps the number of errors to a percentual grade for sub
/// </summary>
public partial class MdlWorkshopformNumerrorsMap
{
    public long Id { get; set; }

    public long Workshopid { get; set; }

    public long Nonegative { get; set; }

    public decimal Grade { get; set; }
}
