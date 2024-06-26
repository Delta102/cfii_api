using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Turnitin Plagiarism Plugin Courses
/// </summary>
public partial class MdlPlagiarismTurnitinCourse
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public string? TurnitinCtl { get; set; }

    public long? TurnitinCid { get; set; }
}
