using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Allows modules to store arbitrary user preferences
/// </summary>
public partial class MdlUserPreference
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;
}
