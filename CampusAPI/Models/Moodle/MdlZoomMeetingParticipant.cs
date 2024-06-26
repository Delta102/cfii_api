using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// A list of each meeting existing on Moodle and when its parti
/// </summary>
public partial class MdlZoomMeetingParticipant
{
    public long Id { get; set; }

    public long? Userid { get; set; }

    public string Zoomuserid { get; set; } = null!;

    public string? Uuid { get; set; }

    public string? UserEmail { get; set; }

    public long JoinTime { get; set; }

    public long LeaveTime { get; set; }

    public long Duration { get; set; }

    public string Name { get; set; } = null!;

    public long Detailsid { get; set; }
}
