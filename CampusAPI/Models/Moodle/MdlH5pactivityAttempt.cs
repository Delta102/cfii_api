using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Users attempts inside H5P activities
/// </summary>
public partial class MdlH5pactivityAttempt
{
    public long Id { get; set; }

    public long H5pactivityid { get; set; }

    public long Userid { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public int Attempt { get; set; }

    public long? Rawscore { get; set; }

    public long? Maxscore { get; set; }

    public decimal Scaled { get; set; }

    public long? Duration { get; set; }

    public bool? Completion { get; set; }

    public bool? Success { get; set; }
}
