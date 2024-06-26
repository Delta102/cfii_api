using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Course completion user records
/// </summary>
public partial class MdlCourseCompletionCritCompl
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Course { get; set; }

    public long Criteriaid { get; set; }

    public decimal? Gradefinal { get; set; }

    public long? Unenroled { get; set; }

    public long? Timecompleted { get; set; }
}
