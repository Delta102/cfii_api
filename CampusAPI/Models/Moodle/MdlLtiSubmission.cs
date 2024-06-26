using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Keeps track of individual submissions for LTI activities.
/// </summary>
public partial class MdlLtiSubmission
{
    public long Id { get; set; }

    public long Ltiid { get; set; }

    public long Userid { get; set; }

    public long Datesubmitted { get; set; }

    public long Dateupdated { get; set; }

    public decimal Gradepercent { get; set; }

    public decimal Originalgrade { get; set; }

    public long Launchid { get; set; }

    public sbyte State { get; set; }
}
