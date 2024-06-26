using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// A list of zoom meeting breakout rooms groups.
/// </summary>
public partial class MdlZoomBreakoutGroup
{
    public long Id { get; set; }

    public long Groupid { get; set; }

    public long Breakoutroomid { get; set; }
}
