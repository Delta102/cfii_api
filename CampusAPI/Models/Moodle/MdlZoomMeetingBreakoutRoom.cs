using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// A list of zoom meeting breakout rooms.
/// </summary>
public partial class MdlZoomMeetingBreakoutRoom
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long Zoomid { get; set; }
}
