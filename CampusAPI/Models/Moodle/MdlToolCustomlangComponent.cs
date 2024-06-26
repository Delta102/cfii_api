using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Contains the list of all installed plugins that provide thei
/// </summary>
public partial class MdlToolCustomlangComponent
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Version { get; set; }
}
