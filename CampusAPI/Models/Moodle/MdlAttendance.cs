using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Attendance module table
/// </summary>
public partial class MdlAttendance
{
    public long Id { get; set; }

    public long Course { get; set; }

    public string? Name { get; set; }

    public long Grade { get; set; }

    public long Timemodified { get; set; }

    public string? Intro { get; set; }

    public short Introformat { get; set; }

    public string? Subnet { get; set; }

    public string Sessiondetailspos { get; set; } = null!;

    public bool? Showsessiondetails { get; set; }

    public bool? Showextrauserdetails { get; set; }
}
