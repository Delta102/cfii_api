using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Course categories
/// </summary>
public partial class MdlCourseCategory
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Idnumber { get; set; }

    public string? Description { get; set; }

    public sbyte Descriptionformat { get; set; }

    public long Parent { get; set; }

    public long Sortorder { get; set; }

    public long Coursecount { get; set; }

    public bool? Visible { get; set; }

    public bool? Visibleold { get; set; }

    public long Timemodified { get; set; }

    public long Depth { get; set; }

    public string Path { get; set; } = null!;

    public string? Theme { get; set; }
}
