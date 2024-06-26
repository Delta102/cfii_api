using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// The overrides to quiz settings on a per-user and per-group b
/// </summary>
public partial class MdlQuizOverride
{
    public long Id { get; set; }

    public long Quiz { get; set; }

    public long? Groupid { get; set; }

    public long? Userid { get; set; }

    public long? Timeopen { get; set; }

    public long? Timeclose { get; set; }

    public long? Timelimit { get; set; }

    public int? Attempts { get; set; }

    public string? Password { get; set; }
}
