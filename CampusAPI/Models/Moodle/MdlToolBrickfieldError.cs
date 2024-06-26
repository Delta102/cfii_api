using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Errors during the accessibility checks
/// </summary>
public partial class MdlToolBrickfieldError
{
    public long Id { get; set; }

    public long Resultid { get; set; }

    public long Linenumber { get; set; }

    public string? Errordata { get; set; }

    public string? Htmlcode { get; set; }
}
