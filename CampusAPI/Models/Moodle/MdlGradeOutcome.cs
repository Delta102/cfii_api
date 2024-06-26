using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// This table describes the outcomes used in the system. An out
/// </summary>
public partial class MdlGradeOutcome
{
    public long Id { get; set; }

    public long? Courseid { get; set; }

    public string Shortname { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public long? Scaleid { get; set; }

    public string? Description { get; set; }

    public sbyte Descriptionformat { get; set; }

    public long? Timecreated { get; set; }

    public long? Timemodified { get; set; }

    public long? Usermodified { get; set; }
}
