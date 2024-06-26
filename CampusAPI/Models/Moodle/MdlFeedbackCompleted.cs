using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// filled out feedback
/// </summary>
public partial class MdlFeedbackCompleted
{
    public long Id { get; set; }

    public long Feedback { get; set; }

    public long Userid { get; set; }

    public long Timemodified { get; set; }

    public long RandomResponse { get; set; }

    public bool AnonymousResponse { get; set; }

    public long Courseid { get; set; }
}
