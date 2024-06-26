using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// The overrides to assign settings.
/// </summary>
public partial class MdlAssignOverride
{
    public long Id { get; set; }

    public long Assignid { get; set; }

    public long? Groupid { get; set; }

    public long? Userid { get; set; }

    public long? Sortorder { get; set; }

    public long? Allowsubmissionsfromdate { get; set; }

    public long? Duedate { get; set; }

    public long? Cutoffdate { get; set; }
}
