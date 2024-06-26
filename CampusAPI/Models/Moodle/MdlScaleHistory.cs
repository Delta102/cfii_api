using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// History table
/// </summary>
public partial class MdlScaleHistory
{
    public long Id { get; set; }

    public long Action { get; set; }

    public long Oldid { get; set; }

    public string? Source { get; set; }

    public long? Timemodified { get; set; }

    public long? Loggeduser { get; set; }

    public long Courseid { get; set; }

    public long Userid { get; set; }

    public string Name { get; set; } = null!;

    public string Scale { get; set; } = null!;

    public string Description { get; set; } = null!;
}
