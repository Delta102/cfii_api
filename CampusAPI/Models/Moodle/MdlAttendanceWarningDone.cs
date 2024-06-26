using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Warnings processed
/// </summary>
public partial class MdlAttendanceWarningDone
{
    public long Id { get; set; }

    public long Notifyid { get; set; }

    public long Userid { get; set; }

    public long Timesent { get; set; }
}
