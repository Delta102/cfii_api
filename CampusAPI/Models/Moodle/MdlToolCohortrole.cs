using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Mapping of users to cohort role assignments.
/// </summary>
public partial class MdlToolCohortrole
{
    public long Id { get; set; }

    public long Cohortid { get; set; }

    public long Roleid { get; set; }

    public long Userid { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long? Usermodified { get; set; }
}
