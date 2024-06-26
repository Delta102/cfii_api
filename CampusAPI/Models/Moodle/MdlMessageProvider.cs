using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table stores the message providers (modules and core sy
/// </summary>
public partial class MdlMessageProvider
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Component { get; set; } = null!;

    public string? Capability { get; set; }
}
