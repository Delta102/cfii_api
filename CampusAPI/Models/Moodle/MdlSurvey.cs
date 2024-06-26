using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Each record is one SURVEY module with its configuration
/// </summary>
public partial class MdlSurvey
{
    public long Id { get; set; }

    public long Course { get; set; }

    public long Template { get; set; }

    public int Days { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public string Name { get; set; } = null!;

    public string Intro { get; set; } = null!;

    public short Introformat { get; set; }

    public string Questions { get; set; } = null!;

    public bool Completionsubmit { get; set; }
}
