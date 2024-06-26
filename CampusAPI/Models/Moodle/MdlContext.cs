using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// one of these must be set
/// </summary>
public partial class MdlContext
{
    public long Id { get; set; }

    public long Contextlevel { get; set; }

    public long Instanceid { get; set; }

    public string? Path { get; set; }

    public sbyte Depth { get; set; }

    public sbyte Locked { get; set; }
}
