using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// info about plugin config
/// </summary>
public partial class MdlPlagiarismTurnitinConfig
{
    public long Id { get; set; }

    public long? Cm { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string ConfigHash { get; set; } = null!;
}
