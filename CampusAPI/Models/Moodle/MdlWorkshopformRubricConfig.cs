using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Configuration table for the Rubric grading strategy
/// </summary>
public partial class MdlWorkshopformRubricConfig
{
    public long Id { get; set; }

    public long Workshopid { get; set; }

    public string? Layout { get; set; }
}
