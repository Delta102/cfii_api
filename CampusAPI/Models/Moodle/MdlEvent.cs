using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// For everything with a time associated to it
/// </summary>
public partial class MdlEvent
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public short Format { get; set; }

    public long Categoryid { get; set; }

    public long Courseid { get; set; }

    public long Groupid { get; set; }

    public long Userid { get; set; }

    public long Repeatid { get; set; }

    public string? Component { get; set; }

    public string Modulename { get; set; } = null!;

    public long Instance { get; set; }

    public short Type { get; set; }

    public string Eventtype { get; set; } = null!;

    public long Timestart { get; set; }

    public long Timeduration { get; set; }

    public long? Timesort { get; set; }

    public short Visible { get; set; }

    public string Uuid { get; set; } = null!;

    public long Sequence { get; set; }

    public long Timemodified { get; set; }

    public long? Subscriptionid { get; set; }

    public long? Priority { get; set; }

    public string? Location { get; set; }
}
