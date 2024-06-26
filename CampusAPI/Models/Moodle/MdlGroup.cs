using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Each record represents a group.
/// </summary>
public partial class MdlGroup
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public string Idnumber { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public sbyte Descriptionformat { get; set; }

    public string? Enrolmentkey { get; set; }

    public long Picture { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
