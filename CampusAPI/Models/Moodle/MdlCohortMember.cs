using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Link a user to a cohort.
/// </summary>
public partial class MdlCohortMember
{
    public long Id { get; set; }

    public long Cohortid { get; set; }

    public long Userid { get; set; }

    public long Timeadded { get; set; }
}
