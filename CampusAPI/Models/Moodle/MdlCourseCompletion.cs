using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Course completion records
/// </summary>
public partial class MdlCourseCompletion
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Course { get; set; }

    public long Timeenrolled { get; set; }

    public long Timestarted { get; set; }

    public long? Timecompleted { get; set; }

    public long Reaggregate { get; set; }
}
