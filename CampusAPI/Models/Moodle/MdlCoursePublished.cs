using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Information about how and when an local courses were publish
/// </summary>
public partial class MdlCoursePublished
{
    public long Id { get; set; }

    public string? Huburl { get; set; }

    public long Courseid { get; set; }

    public long Timepublished { get; set; }

    public bool? Enrollable { get; set; }

    public long Hubcourseid { get; set; }

    public bool? Status { get; set; }

    public long? Timechecked { get; set; }
}
