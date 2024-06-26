using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Maintains lists of blocked users
/// </summary>
public partial class MdlMessageUsersBlocked
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Blockeduserid { get; set; }

    public long? Timecreated { get; set; }
}
