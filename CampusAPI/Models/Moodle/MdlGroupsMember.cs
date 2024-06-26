using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Link a user to a group.
/// </summary>
public partial class MdlGroupsMember
{
    public long Id { get; set; }

    public long Groupid { get; set; }

    public long Userid { get; set; }

    public long Timeadded { get; set; }

    public string Component { get; set; } = null!;

    public long Itemid { get; set; }
}
