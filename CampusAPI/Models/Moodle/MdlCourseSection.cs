using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// to define the sections for each course
/// </summary>
public partial class MdlCourseSection
{
    public long Id { get; set; }

    public long Course { get; set; }

    public long Section { get; set; }

    public string? Name { get; set; }

    public string? Summary { get; set; }

    public sbyte Summaryformat { get; set; }

    public string? Sequence { get; set; }

    public bool? Visible { get; set; }

    public string? Availability { get; set; }

    public long Timemodified { get; set; }
}
