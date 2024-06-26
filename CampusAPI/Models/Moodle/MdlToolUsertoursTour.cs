using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// List of tours
/// </summary>
public partial class MdlToolUsertoursTour
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Pathmatch { get; set; }

    public bool Enabled { get; set; }

    public long Sortorder { get; set; }

    public string Configdata { get; set; } = null!;
}
