using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Info about submitted assignments
/// </summary>
public partial class MdlAssignmentSubmission
{
    public long Id { get; set; }

    public long Assignment { get; set; }

    public long Userid { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Numfiles { get; set; }

    public string? Data1 { get; set; }

    public string? Data2 { get; set; }

    public long Grade { get; set; }

    public string Submissioncomment { get; set; } = null!;

    public short Format { get; set; }

    public long Teacher { get; set; }

    public long Timemarked { get; set; }

    public bool Mailed { get; set; }
}
