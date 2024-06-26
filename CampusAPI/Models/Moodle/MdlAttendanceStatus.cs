using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// attendance_statuses table retrofitted from MySQL
/// </summary>
public partial class MdlAttendanceStatus
{
    public long Id { get; set; }

    public long Attendanceid { get; set; }

    public string Acronym { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Grade { get; set; }

    public long? Studentavailability { get; set; }

    public sbyte? Setunmarked { get; set; }

    public bool? Visible { get; set; }

    public bool Deleted { get; set; }

    public int Setnumber { get; set; }
}
