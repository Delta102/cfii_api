using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// User competencies in a course
/// </summary>
public partial class MdlCompetencyUsercompcourse
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Courseid { get; set; }

    public long Competencyid { get; set; }

    public sbyte? Proficiency { get; set; }

    public long? Grade { get; set; }

    public long Timecreated { get; set; }

    public long? Timemodified { get; set; }

    public long Usermodified { get; set; }
}
