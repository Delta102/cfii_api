using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Default comment for the table, please edit me
/// </summary>
public partial class MdlCompetencyTemplatecohort
{
    public long Id { get; set; }

    public long Templateid { get; set; }

    public long Cohortid { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }
}
