using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// attendance_sessions table
/// </summary>
public partial class MdlAttendanceSession
{
    public long Id { get; set; }

    public long Attendanceid { get; set; }

    public long Groupid { get; set; }

    public long Sessdate { get; set; }

    public long Duration { get; set; }

    public long? Lasttaken { get; set; }

    public long Lasttakenby { get; set; }

    public long? Timemodified { get; set; }

    public string Description { get; set; } = null!;

    public sbyte Descriptionformat { get; set; }

    public bool Studentscanmark { get; set; }

    public bool Autoassignstatus { get; set; }

    public string? Studentpassword { get; set; }

    public string? Subnet { get; set; }

    public bool Automark { get; set; }

    public bool Automarkcompleted { get; set; }

    public int Statusset { get; set; }

    public bool? Absenteereport { get; set; }

    public bool Preventsharedip { get; set; }

    public long? Preventsharediptime { get; set; }

    public long Caleventid { get; set; }

    public bool? Calendarevent { get; set; }

    public bool Includeqrcode { get; set; }

    public bool Rotateqrcode { get; set; }

    public string? Rotateqrcodesecret { get; set; }
}
