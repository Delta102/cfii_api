using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the completion state (completed or not completed, etc
/// </summary>
public partial class MdlCourseModulesCompletion
{
    public long Id { get; set; }

    public long Coursemoduleid { get; set; }

    public long Userid { get; set; }

    public bool Completionstate { get; set; }

    public bool? Viewed { get; set; }

    public long? Overrideby { get; set; }

    public long Timemodified { get; set; }
}
