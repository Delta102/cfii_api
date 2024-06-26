using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Info about upgraded assignments
/// </summary>
public partial class MdlAssignmentUpgrade
{
    public long Id { get; set; }

    public long Oldcmid { get; set; }

    public long Oldinstance { get; set; }

    public long Newcmid { get; set; }

    public long Newinstance { get; set; }

    public long Timecreated { get; set; }
}
