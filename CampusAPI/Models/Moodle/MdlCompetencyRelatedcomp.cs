using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Related competencies
/// </summary>
public partial class MdlCompetencyRelatedcomp
{
    public long Id { get; set; }

    public long Competencyid { get; set; }

    public long Relatedcompetencyid { get; set; }

    public long Timecreated { get; set; }

    public long? Timemodified { get; set; }

    public long Usermodified { get; set; }
}
