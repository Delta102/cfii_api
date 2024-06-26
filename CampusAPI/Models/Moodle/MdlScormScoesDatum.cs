using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Contains variable data get from packages
/// </summary>
public partial class MdlScormScoesDatum
{
    public long Id { get; set; }

    public long Scoid { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;
}
