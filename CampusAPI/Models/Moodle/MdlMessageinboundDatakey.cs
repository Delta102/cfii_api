using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Inbound Message data item secret keys.
/// </summary>
public partial class MdlMessageinboundDatakey
{
    public long Id { get; set; }

    public long Handler { get; set; }

    public long Datavalue { get; set; }

    public string? Datakey { get; set; }

    public long Timecreated { get; set; }

    public long? Expires { get; set; }
}
