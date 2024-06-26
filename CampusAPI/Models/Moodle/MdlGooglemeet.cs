using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the googlemeet activity module instances.
/// </summary>
public partial class MdlGooglemeet
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string Name { get; set; } = null!;

    public string Originalname { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string? Creatoremail { get; set; }

    public string? Intro { get; set; }

    public short Introformat { get; set; }

    public long? Lastsync { get; set; }

    public long Eventdate { get; set; }

    public long Starthour { get; set; }

    public long Startminute { get; set; }

    public long Endhour { get; set; }

    public long Endminute { get; set; }

    public short Addmultiply { get; set; }

    public string? Days { get; set; }

    public short? Period { get; set; }

    public long? Eventenddate { get; set; }

    public short Notify { get; set; }

    public long Minutesbefore { get; set; }

    public long Timemodified { get; set; }

    public string? Eventid { get; set; }
}
