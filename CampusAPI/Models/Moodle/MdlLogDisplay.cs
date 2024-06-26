using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// For a particular module/action, specifies a moodle table/fie
/// </summary>
public partial class MdlLogDisplay
{
    public long Id { get; set; }

    public string Module { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string Mtable { get; set; } = null!;

    public string Field { get; set; } = null!;

    public string Component { get; set; } = null!;
}
