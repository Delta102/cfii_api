using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// List of flags that can be set for a single user in a single 
/// </summary>
public partial class MdlAssignUserFlag
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Assignment { get; set; }

    public long Locked { get; set; }

    public short Mailed { get; set; }

    public long Extensionduedate { get; set; }

    public string? Workflowstate { get; set; }

    public long Allocatedmarker { get; set; }
}
