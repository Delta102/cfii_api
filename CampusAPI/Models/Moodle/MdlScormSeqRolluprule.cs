using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// SCORM2004 sequencing rule
/// </summary>
public partial class MdlScormSeqRolluprule
{
    public long Id { get; set; }

    public long Scoid { get; set; }

    public string Childactivityset { get; set; } = null!;

    public long Minimumcount { get; set; }

    public float Minimumpercent { get; set; }

    public string Conditioncombination { get; set; } = null!;

    public string Action { get; set; } = null!;
}
