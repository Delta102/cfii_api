using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// values of the completedstmp
/// </summary>
public partial class MdlFeedbackValuetmp
{
    public long Id { get; set; }

    public long CourseId { get; set; }

    public long Item { get; set; }

    public long Completed { get; set; }

    public long TmpCompleted { get; set; }

    public string Value { get; set; } = null!;
}
