using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Config data for an instance of a plugin in an assignment.
/// </summary>
public partial class MdlAssignPluginConfig
{
    public long Id { get; set; }

    public long Assignment { get; set; }

    public string Plugin { get; set; } = null!;

    public string Subtype { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
