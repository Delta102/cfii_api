using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// A list of tracking field values for meetings in Zoom.
/// </summary>
public partial class MdlZoomMeetingTrackingField
{
    public long Id { get; set; }

    public long MeetingId { get; set; }

    public string TrackingField { get; set; } = null!;

    public string? Value { get; set; }
}
