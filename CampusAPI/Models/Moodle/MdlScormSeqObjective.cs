using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// SCORM2004 objective description
/// </summary>
public partial class MdlScormSeqObjective
{
    public long Id { get; set; }

    public long Scoid { get; set; }

    public bool Primaryobj { get; set; }

    public string Objectiveid { get; set; } = null!;

    public bool? Satisfiedbymeasure { get; set; }

    public float Minnormalizedmeasure { get; set; }
}
