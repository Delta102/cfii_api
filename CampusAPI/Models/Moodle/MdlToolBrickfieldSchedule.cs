using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Keeps the per course content analysis schedule.
/// </summary>
public partial class MdlToolBrickfieldSchedule
{
    public long Id { get; set; }

    public long Contextlevel { get; set; }

    public long Instanceid { get; set; }

    public long? Contextid { get; set; }

    public sbyte Status { get; set; }

    public long? Timeanalyzed { get; set; }

    public long? Timemodified { get; set; }
}
