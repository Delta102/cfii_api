using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// gradebook settings
/// </summary>
public partial class MdlGradeSetting
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
