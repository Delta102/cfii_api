using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// SCORM2004 objective mapinfo description
/// </summary>
public partial class MdlScormSeqMapinfo
{
    public long Id { get; set; }

    public long Scoid { get; set; }

    public long Objectiveid { get; set; }

    public long Targetobjectiveid { get; set; }

    public bool? Readsatisfiedstatus { get; set; }

    public bool? Readnormalizedmeasure { get; set; }

    public bool Writesatisfiedstatus { get; set; }

    public bool Writenormalizedmeasure { get; set; }
}
