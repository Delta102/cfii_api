using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Link a competency to a module.
/// </summary>
public partial class MdlCompetencyModulecomp
{
    public long Id { get; set; }

    public long Cmid { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }

    public long Sortorder { get; set; }

    public long Competencyid { get; set; }

    public sbyte Ruleoutcome { get; set; }
}
