using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Used by AICC HACP to store session information
/// </summary>
public partial class MdlScormAiccSession
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Scormid { get; set; }

    public string Hacpsession { get; set; } = null!;

    public long? Scoid { get; set; }

    public string? Scormmode { get; set; }

    public string? Scormstatus { get; set; }

    public long? Attempt { get; set; }

    public string? Lessonstatus { get; set; }

    public string? Sessiontime { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
