using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Tracks each users untracked forums
/// </summary>
public partial class MdlForumTrackPref
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Forumid { get; set; }
}
