using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Relationship between user evidence and competencies
/// </summary>
public partial class MdlCompetencyUserevidencecomp
{
    public long Id { get; set; }

    public long Userevidenceid { get; set; }

    public long Competencyid { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long Usermodified { get; set; }
}
