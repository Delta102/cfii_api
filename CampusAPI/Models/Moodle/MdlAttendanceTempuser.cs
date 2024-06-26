using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores temporary users details
/// </summary>
public partial class MdlAttendanceTempuser
{
    public long Id { get; set; }

    public long? Studentid { get; set; }

    public long? Courseid { get; set; }

    public string? Fullname { get; set; }

    public string? Email { get; set; }

    public long? Created { get; set; }
}
