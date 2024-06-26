using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// A list of zoom meeting breakout rooms participants.
/// </summary>
public partial class MdlZoomBreakoutParticipant
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public long Breakoutroomid { get; set; }
}
