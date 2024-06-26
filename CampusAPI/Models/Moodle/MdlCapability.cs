using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// this defines all capabilities
/// </summary>
public partial class MdlCapability
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Captype { get; set; } = null!;

    public long Contextlevel { get; set; }

    public string Component { get; set; } = null!;

    public long Riskbitmask { get; set; }
}
