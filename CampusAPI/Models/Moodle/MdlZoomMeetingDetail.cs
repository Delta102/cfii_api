using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// A queue for the Cron to add meeting report info to zoom_meet
/// </summary>
public partial class MdlZoomMeetingDetail
{
    public string Uuid { get; set; } = null!;

    public long MeetingId { get; set; }

    public long EndTime { get; set; }

    public long Id { get; set; }

    public long StartTime { get; set; }

    public long Duration { get; set; }

    public string Topic { get; set; } = null!;

    public long? TotalMinutes { get; set; }

    public short? ParticipantsCount { get; set; }

    public long Zoomid { get; set; }
}
