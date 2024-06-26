using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// SCORM2004 rule conditions
/// </summary>
public partial class MdlScormSeqRulecond1
{
    public long Id { get; set; }

    public long Scoid { get; set; }

    public string Conditioncombination { get; set; } = null!;

    public sbyte Ruletype { get; set; }

    public string Action { get; set; } = null!;
}
