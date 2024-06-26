using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Users participating in courses (aka enrolled users) - everyb
/// </summary>
public partial class MdlUserEnrolment
{
    public long Id { get; set; }

    public long Status { get; set; }

    public long Enrolid { get; set; }

    public long Userid { get; set; }

    public long Timestart { get; set; }

    public long Timeend { get; set; }

    public long Modifierid { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }
}
