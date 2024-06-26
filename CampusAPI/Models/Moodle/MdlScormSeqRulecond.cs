using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// SCORM2004 rule condition
/// </summary>
public partial class MdlScormSeqRulecond
{
    public long Id { get; set; }

    public long Scoid { get; set; }

    public long Ruleconditionsid { get; set; }

    public string Refrencedobjective { get; set; } = null!;

    public float Measurethreshold { get; set; }

    public string Operator { get; set; } = null!;

    public string Cond { get; set; } = null!;
}
