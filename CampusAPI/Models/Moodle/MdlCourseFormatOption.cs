using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores format-specific options for the course or course sect
/// </summary>
public partial class MdlCourseFormatOption
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public string Format { get; set; } = null!;

    public long Sectionid { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
