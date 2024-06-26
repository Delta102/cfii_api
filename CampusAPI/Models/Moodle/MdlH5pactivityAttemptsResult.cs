using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// H5Pactivities_attempts tracking info
/// </summary>
public partial class MdlH5pactivityAttemptsResult
{
    public long Id { get; set; }

    public long Attemptid { get; set; }

    public string? Subcontent { get; set; }

    public long Timecreated { get; set; }

    public string? Interactiontype { get; set; }

    public string? Description { get; set; }

    public string? Correctpattern { get; set; }

    public string Response { get; set; } = null!;

    public string? Additionals { get; set; }

    public long Rawscore { get; set; }

    public long Maxscore { get; set; }

    public long? Duration { get; set; }

    public bool? Completion { get; set; }

    public bool? Success { get; set; }
}
