using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// to track SCOes
/// </summary>
public partial class MdlScormScoesTrack
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Scormid { get; set; }

    public long Scoid { get; set; }

    public long Attempt { get; set; }

    public string Element { get; set; } = null!;

    public string Value { get; set; } = null!;

    public long Timemodified { get; set; }
}
