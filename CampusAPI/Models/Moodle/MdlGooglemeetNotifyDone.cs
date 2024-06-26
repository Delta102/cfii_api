using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores references from Google Meet recordings.
/// </summary>
public partial class MdlGooglemeetNotifyDone
{
    public long Id { get; set; }

    public long Eventid { get; set; }

    public long Userid { get; set; }

    public long Timesent { get; set; }
}
