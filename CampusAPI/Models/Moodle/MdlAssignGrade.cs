using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Grading information about a single assignment submission.
/// </summary>
public partial class MdlAssignGrade
{
    public long Id { get; set; }

    public long Assignment { get; set; }

    public long Userid { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Grader { get; set; }

    public decimal? Grade { get; set; }

    public long Attemptnumber { get; set; }
}
