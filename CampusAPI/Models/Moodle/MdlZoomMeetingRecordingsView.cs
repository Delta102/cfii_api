using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// A list to track when users view Zoom meeting recordings.
/// </summary>
public partial class MdlZoomMeetingRecordingsView
{
    public long Id { get; set; }

    public long Recordingsid { get; set; }

    public long Userid { get; set; }

    public bool Viewed { get; set; }

    public long? Timemodified { get; set; }
}
