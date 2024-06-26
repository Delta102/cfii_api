using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Plan competencies
/// </summary>
public partial class MdlCompetencyPlancomp
{
    public long Id { get; set; }

    public long Planid { get; set; }

    public long Competencyid { get; set; }

    public long? Sortorder { get; set; }

    public long Timecreated { get; set; }

    public long? Timemodified { get; set; }

    public long Usermodified { get; set; }
}
