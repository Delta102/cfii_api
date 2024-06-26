using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Used by build_context_path() in upgrade and cron to keep con
/// </summary>
public partial class MdlContextTemp
{
    public long Id { get; set; }

    public string Path { get; set; } = null!;

    public sbyte Depth { get; set; }

    public sbyte Locked { get; set; }
}
