using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table contains the course specific settings for compete
/// </summary>
public partial class MdlCompetencyCoursecompsetting
{
    public long Id { get; set; }

    public long Courseid { get; set; }

    public sbyte? Pushratingstouserplans { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public long? Usermodified { get; set; }
}
