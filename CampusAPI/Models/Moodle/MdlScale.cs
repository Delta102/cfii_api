using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Defines grading scales
/// </summary>
public partial class MdlScale
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public long Userid { get; set; }

    public string Name { get; set; } = null!;

    public string Scale { get; set; } = null!;

    public string Description { get; set; } = null!;

    public sbyte Descriptionformat { get; set; }

    public long Timemodified { get; set; }
}
