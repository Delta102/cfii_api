using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Moodle modules and plugins configuration variables
/// </summary>
public partial class MdlConfigPlugin
{
    public long Id { get; set; }

    public string Plugin { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;
}
