using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// History table
/// </summary>
public partial class MdlGradeOutcomesHistory
{
    public long Id { get; set; }

    public long Action { get; set; }

    public long Oldid { get; set; }

    public string? Source { get; set; }

    public long? Timemodified { get; set; }

    public long? Loggeduser { get; set; }

    public long? Courseid { get; set; }

    public string Shortname { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public long? Scaleid { get; set; }

    public string? Description { get; set; }

    public sbyte Descriptionformat { get; set; }
}
