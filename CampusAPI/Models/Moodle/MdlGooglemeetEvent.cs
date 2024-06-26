using System;
using System.Collections.Generic;

namespace CampusAPI.Models.Moodle;

/// <summary>
/// Stores the googlemeet events.
/// </summary>
public partial class MdlGooglemeetEvent
{
    public long Id { get; set; }

    public long Googlemeetid { get; set; }

    public long Eventdate { get; set; }

    public long Duration { get; set; }

    public long Timemodified { get; set; }
}
