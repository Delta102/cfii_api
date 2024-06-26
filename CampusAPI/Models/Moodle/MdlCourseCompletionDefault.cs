using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Default settings for activities completion
/// </summary>
public partial class MdlCourseCompletionDefault
{
    public long Id { get; set; }

    public long Course { get; set; }

    public long Module { get; set; }

    public bool Completion { get; set; }

    public bool Completionview { get; set; }

    public bool Completionusegrade { get; set; }

    public long Completionexpected { get; set; }

    public string? Customrules { get; set; }
}
