using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Link a competency to a course.
/// </summary>
public partial class MdlCompetencyCoursecomp
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public long Competencyid { get; set; }

    public sbyte Ruleoutcome { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }

    public long Sortorder { get; set; }
}
