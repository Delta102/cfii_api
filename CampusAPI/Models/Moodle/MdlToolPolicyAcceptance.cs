using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Tracks users accepting the policy versions
/// </summary>
public partial class MdlToolPolicyAcceptance
{
    public long Id { get; set; }

    public long Policyversionid { get; set; }

    public long Userid { get; set; }

    public bool? Status { get; set; }

    public string Lang { get; set; } = null!;

    public long Usermodified { get; set; }

    public long Timecreated { get; set; }

    public long Timemodified { get; set; }

    public string? Note { get; set; }
}
