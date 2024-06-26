using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// attendance_log table retrofitted from MySQL
/// </summary>
public partial class MdlAttendanceLog
{
    public long Id { get; set; }

    public long Sessionid { get; set; }

    public long Studentid { get; set; }

    public long Statusid { get; set; }

    public string? Statusset { get; set; }

    public long Timetaken { get; set; }

    public long Takenby { get; set; }

    public string? Remarks { get; set; }

    public string? Ipaddress { get; set; }
}
