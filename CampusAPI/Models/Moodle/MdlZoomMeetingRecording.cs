using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// A list of recording links for Zoom meeting activities.
/// </summary>
public partial class MdlZoomMeetingRecording
{
    public long Id { get; set; }

    public long Zoomid { get; set; }

    public string Meetinguuid { get; set; } = null!;

    public string Zoomrecordingid { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Externalurl { get; set; } = null!;

    public string? Passcode { get; set; }

    public string Recordingtype { get; set; } = null!;

    public long Recordingstart { get; set; }

    public bool Showrecording { get; set; }

    public long? Timecreated { get; set; }

    public long? Timemodified { get; set; }
}
