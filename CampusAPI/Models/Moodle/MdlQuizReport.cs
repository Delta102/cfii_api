using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Lists all the installed quiz reports and their display order
/// </summary>
public partial class MdlQuizReport
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long Displayorder { get; set; }

    public string? Capability { get; set; }
}
