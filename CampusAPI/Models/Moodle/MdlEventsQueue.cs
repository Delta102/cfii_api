using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table is for storing queued events. It stores only one 
/// </summary>
public partial class MdlEventsQueue
{
    public long Id { get; set; }

    public string Eventdata { get; set; } = null!;

    public string? Stackdump { get; set; }

    public long? Userid { get; set; }

    public long Timecreated { get; set; }
}
