using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// User competencies
/// </summary>
public partial class MdlCompetencyUsercomp
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Competencyid { get; set; }

    public sbyte Status { get; set; }

    public long? Reviewerid { get; set; }

    public sbyte? Proficiency { get; set; }

    public long? Grade { get; set; }

    public long Timecreated { get; set; }

    public long? Timemodified { get; set; }

    public long Usermodified { get; set; }
}
