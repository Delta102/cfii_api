using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Each record represents one cohort (aka site-wide group).
/// </summary>
public partial class MdlCohort
{
    public long Id { get; set; }

    public long Contextid { get; set; }

    public string Name { get; set; } = null!;

    public string? Idnumber { get; set; }

    public string? Description { get; set; }

    public sbyte Descriptionformat { get; set; }

    public bool? Visible { get; set; }

    public string Component { get; set; } = null!;

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public string? Theme { get; set; }
}
